namespace Write.Domain.Events
{
    public class BecameCustomerEvent : Event
    {
        public string Email { get; }
        public string Username { get; }

        public BecameCustomerEvent(string email, string username)
        {
            Email = email;
            Username = username;
        }
    }
}