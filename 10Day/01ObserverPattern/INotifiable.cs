namespace _01ObserverPattern
{
    /// <summary>
    /// Define Observer's "Knowledge":
    /// it must have a function to be notified
    /// 
    /// In order to avoid changing the parameters on the signature of the function, the parameters are closed in a class instance.
    /// 
    /// DTO: Data Transfer Object
    /// https://martinfowler.com/eaaCatalog/dataTransferObject.html
    /// </summary>
    public interface INotifiable
    {
        void Message(IMessage data);
    }
}