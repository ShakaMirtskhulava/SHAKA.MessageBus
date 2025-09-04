using System.Text.Json.Serialization;

namespace MessageBus.Events;

public record IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
    }

    public IntegrationEvent(object entityId, Dictionary<string,object>? additionalData = null)
    {
        EntityId = entityId;
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
        AdditionalData = additionalData;
    }

    [JsonInclude]
    public Guid Id { get; set; }
    [JsonInclude]
    public DateTime CreationDate { get; set; }
    [JsonInclude]
    public string? CorrelationId { get; set; }
    [JsonInclude]
    public object? EntityId { get; set; }
    [JsonInclude]
    public Dictionary<string, object>? AdditionalData { get; set; }
}

