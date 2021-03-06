﻿using System;
using MyMessages;
using NServiceBus;

namespace MySubscriber2
{
    public class FooEventHandler : IHandleMessages<IFooEvent>
    {
        public void Handle(IFooEvent message)
        {
            if (message == null)
            {
                throw new Exception("Outrageous!");
            }

            Console.WriteLine("Handling event message (subscriber #2): {0}", message.Bar);
        }
    }
}
