using System;

namespace _02FakeCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = new FakeCoin();

            // DoCollect() function waits for a Coin type argument, so in background runs a type casting from FakeCoin to Coin.
            // The type conversion means that the instance will be accessed through the Coin interface.
            // This can works because FakeCoin is derived from the Coin class.
            DoCollect(coin);

            Console.ReadLine();
        }

        private static void DoCollect(Coin coin)
        {
            Console.WriteLine("Result of coin collection:");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Collect()}, ");
            }
        }
    }
}
