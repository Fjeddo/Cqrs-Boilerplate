namespace Write.Domain.Events
{
    public class CreditCardDemotedEvent : Event
    {
        public string CreditCard { get; }

        public CreditCardDemotedEvent(string creditCard)
        {
            CreditCard = creditCard;
        }
    }
}