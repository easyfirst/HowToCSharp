namespace _01ConstructorFinalizer
{
    public class Third : Middle
    {
        //public Third()
        //{
        //    System.Console.WriteLine("This is the constructor of Third class: Third()");
        //}

        public Third(string name, string email) : base(name, email)
        {
            System.Console.WriteLine("This is the constructor of Third class: Third(string name, string email)");
        }
    }
}