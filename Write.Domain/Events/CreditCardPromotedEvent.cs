
namespace Write.Domain.Events
{
    public class CreditCardPromotedEvent : Event
    {
        public string CreditCard { get; }

        public CreditCardPromotedEvent(string creditCard)
        {
            CreditCard = creditCard;
        }
    }
}