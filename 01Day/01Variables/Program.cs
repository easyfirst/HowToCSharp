using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Variables {
    class Program {
        static void Main(string[] args) {

            // Value types

            var value1 = 10;

            //earlier we should write so
            //int value1 = 10;

            //what really happening
            //Int32 value1 = 10;

            var value2 = value1;

            Console.WriteLine($"value1: {value1} , value2: {value2}");
            //value1: 10 , value2: 10

            value1 = 20;

            Console.WriteLine($"value1: {value1} , value2: {value2}");
            //value1: 20 , value2: 10

            //The two variables are completely independent of each other.
            // Value types are:
            //bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort

            Console.ReadKey();
        }
    }
}
