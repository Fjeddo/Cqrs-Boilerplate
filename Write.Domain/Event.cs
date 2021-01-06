using System;

namespace Write.Domain
{
    public abstract class Event
    {
        public DateTimeOffset Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTimeOffset.UtcNow;
        }
    }
}