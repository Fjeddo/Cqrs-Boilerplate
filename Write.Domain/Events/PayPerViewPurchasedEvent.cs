using System;

namespace Write.Domain.Events
{
    public class PayPerViewPurchasedEvent : Event
    {
        public Guid MovieId { get; }

        public PayPerViewPurchasedEvent(Guid movieId)
        {
            MovieId = movieId;
        }
    }
}