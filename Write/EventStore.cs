using System.Collections.Generic;
using Write.Domain;

namespace Write
{
    public static class EventStore
    {
        private static readonly List<Event> Events = new List<Event>();

        public static void Add(Event e)
        {
            Events.Add(e);
        }

        public static IReadOnlyCollection<Event> GetHistory()
        {
            return Events.AsReadOnly();
        }
    }
}
