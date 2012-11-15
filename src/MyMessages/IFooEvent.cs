using NServiceBus;

namespace MyMessages
{
    public interface IFooEvent : IEvent
    {
        string Bar { get; set; }
    }
}
