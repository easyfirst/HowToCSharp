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


            //Task: How can we reduce this four steps ???

            //////////////////////////////
            //1. reduction step: a lambda
            //////////////////////////////

            //using lambda, you can reduce step 2.a / 2.b to one step

            //The lambda expression (=>) a line function definition
            //on the left side there is a list of parameters in parentheses separated by commas,
            //and on the right there is a function body (tribe).

            //the function name had to be a reference because the lambda was written there,
            //where the function name is no longer needed

            //if there are 1 parameters AND I use only one expression then no parentheses are needed () {}
            squaringProcesslist = y => y * y;

            //the same is in code block:
            squaringProcesslist = (x) => { return x * x; };
            //I can use any line in the code block:

            squaringProcesslist = (integerNum) =>
            {
                Console.WriteLine($"I raise a square, parameter: {integerNum}");
                return integerNum * integerNum;
            };

            Console.WriteLine($"square of 2: {squaringProcesslist(2)}");


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
