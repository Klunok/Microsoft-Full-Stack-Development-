namespace EventEase.Models;

public class EventRegistration
{
    public int EventId { get; init; }
    public Guid SessionId { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public DateTime RegisteredAtUtc { get; init; } = DateTime.UtcNow;
}
