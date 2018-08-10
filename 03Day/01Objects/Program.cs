using System;

namespace _01Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane1 = new Plane();
            var plane2 = new Plane();

            // Indentity :
            // This investigates if the 2 reference points to the same place.
            if (plane1 == plane2)
            {
                Console.WriteLine("The 2 instances are same.");
            }
            else
            {
                Console.WriteLine("The 2 instances are NOT same.");
            }

            // storing state
            plane1.NrOfEdge = 3;
            plane2.NrOfEdge = 5;

            plane1.Name = "PLANE";
            Console.WriteLine(plane1.Name);

            plane1.Show(1, 3);

            // Valu type argument passig
            var value = 2;
            // Reference type argument passig
            var refernce = new ReferenceType() { value = 3 };
            // We can pass valu type argument as reference
            var value2 = 4;

            Console.WriteLine($"value: {value} , refernce.value: {refernce.value} , value2: {value2}");

            // If the argument passing is defferint from the default (value2 / value3),
            // then it must be signed with "ref" / "out" keyword by calling in function.

            int value3;
            plane1.Show(value, refernce, ref value2, out value3);

            // This format can be used from VS 2015 :
            //plane1.Show(value, refernce, ref value2, out int value3);

            Console.WriteLine($"value: {value} , refernce.value: {refernce.value} , value2: {value2} , value3: {value3}");

            // The default parameters can be omitted.
            plane1.Show();   // this call the function without argment

            // The argument "height" doas't have to be set to value because it has a default value ("5").
            System.Console.WriteLine("\r\nShow() function called with default values:");
            System.Console.WriteLine($"Show(width: 9, name: 'something')\r\n");
            plane1.Show(width: 9, name: "something");

            Console.ReadLine();
        }
    }
}
