namespace paystream.src.domain;

public class EventEntity
{
    public Guid EventId { get; set; }
    public string EventType { get; set; } = string.Empty;
}