namespace Write.Domain
{
    public abstract class State
    {
        public void Mutate(Event @event) => DynamicRouteToWhen(@event as dynamic);
        
        protected abstract void DynamicRouteToWhen(dynamic e);
    }
}