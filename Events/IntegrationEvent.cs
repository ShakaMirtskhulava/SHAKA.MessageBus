using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace MessageBus.Events;

public record IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
    }

    public IntegrationEvent(object entityId)
        : base()
    {
        EntityId = entityId;
    }

    [JsonInclude]
    public Guid Id { get; set; }
    [JsonInclude]
    public DateTime CreationDate { get; set; }
    [JsonInclude]
    public string? CorrelationId { get; set; }
    [JsonInclude]
    public object? EntityId { get; set; }
}

