using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Notifications.Api.Hubs;
using Notifications.Api.Interfaces;
public class NotificationController : ControllerBase
{
    private readonly IHubContext<NotificationsHub, INotificationClient> _hubContext;

    public NotificationController(IHubContext<NotificationsHub, INotificationClient> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost("api/notify")]
    public async Task<IActionResult> Notify(string message)
    {
        try
        {
            await _hubContext.Clients.All.ReceiveNotification(message);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}