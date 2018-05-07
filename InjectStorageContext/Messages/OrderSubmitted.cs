﻿using System;
using NServiceBus;

namespace InjectStorageContext.Messages
{
    public class OrderSubmitted : IMessage
    {
        public Guid OrderId { get; set; }
        public string Value { get; set; }
    }
}