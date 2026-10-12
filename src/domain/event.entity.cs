namespace paystream.src.domain;

public class EventEntity
{
    public Guid EventId { get; set; }
    public String EventType { get; set; } = string.Empty;
}