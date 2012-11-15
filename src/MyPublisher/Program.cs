using System;
using MyMessages;
using NServiceBus;
using NServiceBus.Installation.Environments;

namespace MyPublisher
{
    class Program
    {
        static void StartupAction()
        {
            Configure.Instance.ForInstallationOn<Windows>().Install();
        }

        static void Main()
        {
            Console.WriteLine("This is the publisher.");

            var bus = Configure.With()
                .DefaultBuilder()
                .MsmqSubscriptionStorage()
                .DisableTimeoutManager()
                .UnicastBus()
                .CreateBus()
                .Start(StartupAction);

            while (true)
            {
                var input = Console.ReadLine();

                Console.WriteLine("Publishing: {0}", input);

                bus.Publish<IFooEvent>(foo => { foo.Bar = input; });
            }
        }
    }
}
