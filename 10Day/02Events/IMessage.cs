namespace _01ObserverPattern
{
    /// <summary>
    /// This interface includes everything what the observed class wants to share with the observers.
    /// </summary>
    public interface IMessage
    {
        int Data { get; set; }
        string Text { get; set; }
    }
}