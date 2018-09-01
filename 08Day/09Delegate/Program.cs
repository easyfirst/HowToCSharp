using System;

namespace _09Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeWithDelegate = new DataStoreWithDelegate(data: new int[] { 1, 3, 4, 5, 7, 8, 10, 15, 30 });

            #region 1. type of using delegate
            // have to do for using:
            // 1. You need to define a delegate type (ProcessDef) (called page)
            // 2. Define a function corresponding to the delegate (SumOfOdd) (call page)
            // 3. The function must be received with a variable at the point of use Process (ProcessDef strategy) (called page)
            // 4. The function must be sent for use (call page)
            var sum = storeWithDelegate.Process(SumOfOdd);

            Console.WriteLine($"1. type of using delegate");  // 31
            Console.WriteLine($"Sum odd numbers: {sum}\r\n");  // 31
            #endregion 1. type of using delegate


            
            #region 2. type of using delegate
            // On the called page instead of the delegate + parameter pickup using the Func <> definition in the Process2 function.
            // 1. A corresponding function must be converted: Func <int [], int> (called page)
            // 2. Define a function corresponding to the delegate (SumOfOdd) (call page)
            // 3. The function must be sent for use (call page)
            sum = storeWithDelegate.Process2(SumOfOdd);

            Console.WriteLine($"2. type of using delegate");  // 31
            Console.WriteLine($"Sum odd numbers: {sum}\r\n");  // 31
            #endregion 2. type of using delegate



            #region 3. type of using delegate
            // 1. A corresponding function must be converted: Func <int [], int> (called page)
            // 2. We will send the function LAMBDA defined within the line.
            sum = storeWithDelegate.Process3(data =>
            {
                var s = 0;
                foreach (var d in data)
                {
                    //We look for odd numbers.
                    // % is the sign of the integer dividing
                    // if divided by 2 we get 1 left, the number is odd
                    if (d % 2 == 1)
                    {
                        s += d;
                    }
                }
                return s;
            });

            Console.WriteLine($"3. type of using delegate");  // 31
            Console.WriteLine($"Sum odd numbers: {sum}\r\n");  // 31
            #endregion 3. type of using delegate


            Console.ReadLine();
        }

        /// <summary>
        /// Addition of odd numbers
        /// </summary>
        /// <returns></returns>
        private static int SumOfOdd(int[] data)
        {
            var sum = 0;
            foreach (var d in data)
            {
                //We look for odd numbers.
                // % is the sign of the integer dividing
                // if divided by 2 we get 1 left, the number is odd
                if (d % 2 == 1)
                {
                    sum += d;
                }
            }

            return sum;
        }
    }
}
