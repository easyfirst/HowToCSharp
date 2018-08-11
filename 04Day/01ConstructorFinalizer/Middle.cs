namespace _01ConstructorFinalizer
{
    public class Middle : Base
    {
        // If there is no constructor implemented then the builder create self a default constructor without parameters.
        // It runs so as long as there is constructor implemented by the developer.
        // public Middle() { }

        //public Middle()
        //{
        //    System.Console.WriteLine("This is the constructor of Middle class: Middle()");
        //}

        public Middle(string name, string email)
            : base(name, email) // Because we have only one ancestor class, this will invocate the class with the proper signature constructor.
        {
            System.Console.WriteLine("This is the constructor of Middle class: Middle(string name, string email)");
        }

        ~Middle()
        {
            System.Console.WriteLine("This the finalizer of Middle() class.");
        }
    }
}