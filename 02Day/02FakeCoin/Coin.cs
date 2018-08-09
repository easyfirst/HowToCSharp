using System;

namespace _02FakeCoin
{
    public class Coin
    {
        public Coin()
        {
            System.Console.WriteLine("Constructor of Coin.");
        }
        Random random = new Random();

        // Enable to override (to fake) the function with "virtual" keyword.
        public virtual int Collect()
        {
            Console.Write("Coin.Collect()");

            return random.Next(0, 2);
        }
    }
}