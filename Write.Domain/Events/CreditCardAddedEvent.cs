namespace Write.Domain.Events
{
    public class CreditCardAddedEvent : Event
    {
        public string CreditCard { get; }

        public CreditCardAddedEvent(string creditCard)
        {
            CreditCard = creditCard;
        }
    }
}