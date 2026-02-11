using DnD35EDMTools.Data.Classes;

namespace DnD35EDMTools.Services;

public class NotificationService
{
    public event Func<Task> OnChange;
    private readonly List<Notification> notifications = new();

    private const int MaxVisibleNotifications = 5;

    public IEnumerable<Notification> Notifications => notifications;

    public async Task AddNotification(NotificationType type, string message, int durationSeconds = 5)
    {
        if (notifications.Count >= MaxVisibleNotifications)
        {
            notifications.RemoveAt(0);
        }

        notifications.Add(new Notification
        {
            Message = message,
            Type = type,
            CreatedAt = DateTime.Now,
            DurationSeconds = durationSeconds
        });

        if (OnChange != null)
        {
            await OnChange.Invoke(); // Trigger the UI update event
        }
    }

    public async Task RemoveNotification(Guid id)
    {
        var notification = notifications.FirstOrDefault(n => n.Id == id);
        if (notification != null)
        {
            notifications.Remove(notification);
            if (OnChange != null)
            {
                await OnChange.Invoke();
            }
        }
    }
}