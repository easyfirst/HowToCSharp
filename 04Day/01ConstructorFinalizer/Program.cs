using System;

namespace _01ConstructorFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Base();
            Console.WriteLine();

            //var m = new Middle();
            //Console.WriteLine();

            //var t = new Third();
            //Console.WriteLine();

            // Using constructors with parameters.
            Console.WriteLine("-        * * *        -");
            Console.WriteLine("Calling the\r\n'Base('This is the Base class')'\r\nconstructor:");
            b = new Base("This is the Base class");
            Console.WriteLine("The result:");
            Console.WriteLine($"The Base() class name: {b.Name} , email: {b.Email}");
            Console.WriteLine();

            Console.WriteLine("-        * * *        -");
            Console.WriteLine("Calling the\r\n'Base('This is the Base class', 'alap @alap.hu')'\r\nconstructor:");
            b = new Base("This is the Base class", "alap@alap.hu");
            Console.WriteLine("The result:");
            Console.WriteLine($"The Base() class name: {b.Name} , email: {b.Email}");
            Console.WriteLine();

            Console.WriteLine("-        * * *        -");
            Console.WriteLine("Calling the\r\n'Middle('This is the Middle class', 'middle@middle.hu')'\r\nconstructor:");
            var m = new Middle("This the Middle() class", "middle@middle.hu");
            Console.WriteLine("The result:");
            Console.WriteLine($"The Middle() class name: {m.Name} , email: {m.Email}");
            Console.WriteLine();

            Console.WriteLine("-        * * *        -");
            var t = new Third("This the Third() class", "third@third.hu");
            Console.WriteLine("The result:");
            Console.WriteLine($"The Third() class name: {t.Name} , email: {t.Email}");
            Console.WriteLine();

            b = null;
            m = null;
            t = null;

            //This code is necessary to force to run the Garbage Collector.
            //
            GC.Collect();

            Console.ReadLine();
        }
    }
}
