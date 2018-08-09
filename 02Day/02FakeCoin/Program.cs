using System;

namespace _02FakeCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin coin = new FakeCoin();

            Console.WriteLine("Result of coin collection:");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Collect()}, ");
            }

            Console.ReadLine();
        }
    }
}
