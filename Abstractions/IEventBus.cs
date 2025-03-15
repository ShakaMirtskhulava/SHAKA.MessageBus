﻿using MessageBus.Events;

namespace MessageBus.Abstractions;

public interface IEventBus
{
    Task PublishAsync(IntegrationEvent @event);
    public bool IsReady { get; }
}
