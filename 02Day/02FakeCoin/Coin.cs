using System;

namespace _02FakeCoin
{
    public class Coin
    {
        Random random = new Random();

        public int Collect()
        {
            return random.Next(0, 2);
        }
    }
}