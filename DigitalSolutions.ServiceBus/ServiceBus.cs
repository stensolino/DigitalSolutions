﻿using MassTransit;
using System;

namespace DigitalSolutions.ServiceBus
{
    public class ServiceBus
    {
        public IBusControl ConfigureBus()
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });
            });
        }
    }
}
