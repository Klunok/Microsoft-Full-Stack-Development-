namespace EventEase.Services;

public class UserSessionTracker
{
    private readonly HashSet<int> _registeredEventIds = [];

    public Guid SessionId { get; } = Guid.NewGuid();
    public string? Name { get; private set; }
    public string? Email { get; private set; }
    public IReadOnlyCollection<int> RegisteredEventIds => _registeredEventIds;
    public bool HasProfile => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email);

    public void UpdateProfile(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void MarkRegistered(int eventId) => _registeredEventIds.Add(eventId);
}
