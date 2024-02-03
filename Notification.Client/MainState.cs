public delegate void NotificationEventHandler();
public class MainState
{
    public event NotificationEventHandler NotificationEvent;
    private readonly List<string> messages = new List<string>();
    public IList<string> MessagesList => messages;

    public int CurrentCount { get;  private set;}

    public void IncrementCount()
    {
        CurrentCount++;
        NotificationEvent?.Invoke();
    }


    public async Task AddTolist(string value)
    {
        messages.Add(value);
        NotificationEvent?.Invoke();

    }
    public void ClearList()
    {
        MessagesList.Clear();
        CurrentCount = 0;
        NotificationEvent?.Invoke();
    }
}