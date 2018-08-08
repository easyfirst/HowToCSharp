using System;

namespace _02FakeCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = new Coin();

            Console.WriteLine("Result of coin collection:");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Collect()}, ");
            }

            Console.ReadLine();
        }
    }
}
