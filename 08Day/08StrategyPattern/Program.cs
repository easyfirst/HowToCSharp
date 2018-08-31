using System;

namespace _08StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DataStore(data: new int[] {1, 3, 4, 5, 7, 8, 10, 15, 30});

            var sum = store.SumOfOdd();
            Console.WriteLine($"Sum  odd numbers: {sum}");  // 31

            sum = store.ProductOfEven();
            Console.WriteLine($"Multiplication eve numbers: {sum}");    // 9600



            //Same process with help of Strategy Pattern.
            // My datastore.
            var storeWStrategy = new DataStoreWithStrategy(data: new int[] { 1, 3, 4, 5, 7, 8, 10, 15, 30 });

            //Mode of operation, Process method:
            var strategy = new sumOfOddStrategy();

            //Connects the data store with the mode of operation.
            storeWStrategy.SetStrategy(strategy);

            //We ask to complete the operation.
            sum = storeWStrategy.Process();
            Console.WriteLine($"Sum  odd numbers: {sum}");  // 31

            Console.ReadLine();
        }
    }
}
