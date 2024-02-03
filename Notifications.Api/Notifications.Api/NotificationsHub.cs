
using Microsoft.AspNetCore.SignalR;
using Notifications.Api.Interfaces;

namespace Notifications.Api.Hubs;
public class NotificationsHub : Hub<INotificationClient>
{
    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await base.OnDisconnectedAsync(exception);
    }
}

