using System;

namespace _01ConstructorFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Base();
            Console.WriteLine();

            var m = new Middle();
            Console.WriteLine();

            var t = new Third();
            Console.WriteLine();

            // Using constructors with parameters.
            Console.WriteLine("Calling the\r\n'Base('This is the Base class')'\r\nconstructor:");
            b = new Base("This is the Base class");
            Console.WriteLine();

            Console.WriteLine("Calling the\r\n'Base('This is the Base class', 'alap @alap.hu')'\r\nconstructor:");
            b = new Base("This is the Base class", "alap@alap.hu");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
