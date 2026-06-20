using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly object _sync = new();
    private readonly List<EventItem> _events =
    [
        new()
        {
            Id = 1,
            Name = "Corporate Leadership Summit",
            Date = new DateTime(2026, 7, 15),
            Location = "New York",
            Description = "A summit for business leaders and executives.",
            Capacity = 120
        },
        new()
        {
            Id = 2,
            Name = "Social Networking Night",
            Date = new DateTime(2026, 8, 3),
            Location = "Chicago",
            Description = "An evening networking event for professionals.",
            Capacity = 80
        }
    ];

    private readonly List<EventRegistration> _registrations = [];

    public IReadOnlyList<EventItem> GetAll() => _events;

    public EventItem? GetById(int id) => _events.FirstOrDefault(eventItem => eventItem.Id == id);

    public int GetRegistrationCount(int eventId)
    {
        lock (_sync)
        {
            return _registrations.Count(registration => registration.EventId == eventId);
        }
    }

    public IReadOnlyList<AttendanceSummary> GetAttendance()
    {
        lock (_sync)
        {
            return _events
                .Select(eventItem => new AttendanceSummary(
                    eventItem,
                    _registrations.Count(registration => registration.EventId == eventItem.Id)))
                .ToList();
        }
    }

    public RegistrationResult Register(EventRegistration registration)
    {
        lock (_sync)
        {
            var eventItem = GetById(registration.EventId);
            if (eventItem is null)
            {
                return RegistrationResult.EventNotFound;
            }

            if (_registrations.Any(item => item.EventId == registration.EventId && item.SessionId == registration.SessionId))
            {
                return RegistrationResult.AlreadyRegistered;
            }

            if (_registrations.Count(item => item.EventId == registration.EventId) >= eventItem.Capacity)
            {
                return RegistrationResult.EventFull;
            }

            _registrations.Add(registration);
            return RegistrationResult.Success;
        }
    }
}
