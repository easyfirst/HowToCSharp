namespace _01ObserverPattern
{
    /// <summary>
    /// Define Observer's "Knowledge":
    /// it must have a function to be notified
    /// </summary>
    public interface IMessage
    {
        void Message(int data);
    }
}