namespace Write.Domain.Events
{
    public class CreditCardRemovedEvent : Event
    {
        public string CreditCard { get; }

        public CreditCardRemovedEvent(string creditCard)
        {
            CreditCard = creditCard;
        }
    }
}