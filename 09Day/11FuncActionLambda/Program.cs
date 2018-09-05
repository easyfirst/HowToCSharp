using System;

namespace _11FuncActionLambda
{
    class Program
    {
        delegate int SquaringDef(int x); //squaring delegate def (1)
        static void Main(string[] args)
        {
            // 4 steps for using delegate
            // 1. definition of the delegate
            // 2.a. definition of the function
            // 2.b. definition of the call list and filling up
            // 3. calling the call list
            SquaringDef squaringProcesslist = SquaringFunc; //(2.b)
                                                            //I do not check the definition of the call list 
            Console.WriteLine($"squar of 2: {squaringProcesslist(2)}");

            Console.ReadLine();
        }
        /// <summary>
        /// 2.a.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static int SquaringFunc(int x)
        {
            return x * x;
        }
    }
}
