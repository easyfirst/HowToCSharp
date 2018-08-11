namespace _01ConstructorFinalizer
{
    public class Base
    {
        /// <summary>
        /// The "readonly" keyword means this variable can be setted only in the constructor.
        /// </summary>
        private readonly bool isConstructed; // = false;

        /// <summary>
        /// Special function: Constructor
        /// </summary>
        public Base()
        {
            System.Console.WriteLine("This is the constructor of Base class: Base()");

            // Settings can be created, what can be solved without external parameters.
            // Example:
            isInitated = true;

            // This variable with "readonly" keyword means can be setted only in the constructor.
            isConstructed = true;
        }

        /// <summary>
        /// Second constructor, using the overloading possibility.
        /// If strict different as defined, it could be more than one constructor with the same name.
        /// </summary>
        /// <param name="name"></param>
        public Base(string name)
            : this() // With this format is invoked the constructor without parameters.
        {
            System.Console.WriteLine("This is the constructor of Base class: Base(string name)");
            Name = name;
        }

        public Base(string name, string email)
            : this(name)    // With this format is invoked the constructor with parameter "name".
        {
            System.Console.WriteLine("This is the constructor of Base class: Base(string name, string email)");
            Email = email;
        }


        public string Name { get; private set; }
        /// <summary>
        /// This will show if the function is initialized.
        /// The bool type variables always have the default "false" value.
        /// </summary>
        public bool isInitated { get; private set; } //= true;   It's same as if it's settled in constructor.

        /// <summary>
        /// Read-only property: It is only readable, BUT it is writable in constructor !
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// This is the filezier of this class.
        /// - it is not invokable.
        /// - it has no parameters.
        /// - it doesn't return back.
        /// - it will be invoked by framework
        /// </summary>
        ~Base()
        {
            System.Console.WriteLine($"This the finalizer of Base() class. Name: {Name} , Email: {Email}");
        }
    }
}