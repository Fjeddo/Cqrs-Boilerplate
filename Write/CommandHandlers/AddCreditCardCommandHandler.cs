﻿using System;
using System.Linq;
using Persistance;
using Write.Commands;
using Write.Domain;

namespace Write.CommandHandlers
{
    public class AddCreditCardCommandHandler : ICommandHandler<AddCreditCardCommand>
    {
        public void Handle(AddCreditCardCommand command)
        {
            var state = AccountState.FromStorage(AccountStore.AccountStates.SingleOrDefault(x => x.Email == command.Email));

            if (state == null)
            {
                throw new Exception("Not found");
            }

            var agg = Domain.Account.Create(state);

            agg.AddCreditCard(command.CreditCard);

            foreach (var change in agg.Changes())
            {
                EventStore.Add(change);
            }

            AccountStore.Update(state.ToStorage());
        }
    }
}