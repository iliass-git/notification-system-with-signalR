namespace Notifications.Api.Interfaces
{
    public interface INotificationClient
    {
        Task ReceiveNotification(string message);
    }
}