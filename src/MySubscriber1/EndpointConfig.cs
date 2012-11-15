using System;
using NServiceBus;

namespace MySubscriber1
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization, IWantToRunWhenBusStartsAndStops
    {
        public void Init()
        {
            Configure.With()
                .DefaultBuilder()
                .DisableTimeoutManager()
                .UnicastBus();
        }

        public void Start()
        {
            Console.WriteLine("This is subscriber #1.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped.");
        }
    }
}
