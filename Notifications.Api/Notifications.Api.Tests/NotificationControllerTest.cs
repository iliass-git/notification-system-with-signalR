using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Notifications.Api.Hubs;
using Notifications.Api.Interfaces;

public class NotificationControllerTests
{
    [Fact]
    public async Task Notify_ShouldReturnOkResult_WhenNotificationSentSuccessfully()
    {
        // Arrange
        var message = "Test message";
        var mockHubContext = new Mock<IHubContext<NotificationsHub, INotificationClient>>();
        mockHubContext.Setup(h => h.Clients.All.ReceiveNotification(message)).Returns(Task.CompletedTask);
        var controller = new NotificationController(mockHubContext.Object);

        // Act
        var result = await controller.Notify(message);

        // Assert
        Assert.IsType<OkResult>(result);
    }
}
