namespace DnD35EDMTools.Data.Classes;

public class Notification
{
    public string Message { get; set; }
    public NotificationType Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public int DurationSeconds { get; set; }
    public Guid Id { get; } = Guid.NewGuid();
}

public enum NotificationType
{
    Success,
    Error,
    Warning,
    Info
}
