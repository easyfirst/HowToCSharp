﻿using System;
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

            //Console.ReadKey();

            // ---------------------------- * * * ----------------------------

            // Reference Type

            var reference1 = new OwnReference();
            reference1.value = 10;

            var reference2 = reference1;

            Console.WriteLine($"reference1.value: {reference1.value} , reference2.value: {reference2.value}");
            //reference1.value: 10 , reference2.value: 10

            reference2.value = 20;

            Console.WriteLine($"reference1.value: {reference1.value} , reference2.value: {reference2.value}");
            //reference1.value: 20 , reference2.value: 20

            // Reference Types are:
            //string
            //All arrays, even if their elements are value types
            //Class
            //Delegates

            // ---------------------------- * * * ----------------------------

            var tempArray1 = new int[] { 10 };

            var tempArray2 = tempArray1;

            Console.WriteLine($"tempArray1: {tempArray1[0]} , tempArray2: {tempArray2[0]}");
            // tempArray1: 10 , tempArray2: 10

            tempArray2[0] = 20;

            Console.WriteLine($"tempArray1: {tempArray1[0]} , tempArray2: {tempArray2[0]}");
            // tempArray1: 20 , tempArray2: 20

            // ---------------------------- * * * ----------------------------

            // Array of chars
            var string1 = new string(new char[] { '1', '0' });

            //what really happening
            //var string1 = "10";

            var string2 = string1;

            Console.WriteLine($"string1: {string1} , string2: {string2}");
            // string1: 10 , string2: 10

            string1 = "20";

            Console.WriteLine($"string1: {string1} , string2: {string2}");
            // string1: 20 , string2: 10

            //Conclusion: 
            // The string is reference type variable , but behaves like value type variable.

            // ---------------------------- * * * ----------------------------

            // Own complex type of value

            var ownValue1 = new OwnValue();
            ownValue1.value = 10;
            ownValue1.reference = new OwnReference { value = 10 };

            //This format is the same like above !
            //var ownValue1 = new OwnValue {
            //
            //    value = 10
            //};

            var ownValue2 = ownValue1;

            Console.WriteLine($"ownValue1.value: {ownValue1.value} , ownValue2.value: {ownValue2.value}");
            // ownValue1.value: 10 , ownValue2.value: 10

            Console.WriteLine($"ownValue1.reference.value: {ownValue1.reference.value} , ownValue2.reference.value: {ownValue2.reference.value}");
            // ownValue1.reference.value: 10 , ownValue2.reference.value: 10

            ownValue1.value = 20;
            ownValue1.reference.value = 20;

            Console.WriteLine($"ownValue1.value: {ownValue1.value} , ownValue2.value: {ownValue2.value}");
            // ownValue1.value: 20 , ownValue2.value: 10

            Console.WriteLine($"ownValue1.reference.value: {ownValue1.reference.value} , ownValue2.reference.value: {ownValue2.reference.value}");
            // ownValue1.reference.value: 20 , ownValue2.reference.value: 20

            //Conclusion: 
            // The value variable created with "struct" keyword  behaves like value type variable.
            // But, the reference type variable in it BEHAVES like a reference type variable !!!

            // ---------------------------- * * * ----------------------------

            Console.ReadKey();
        }
    }
}
