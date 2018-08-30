using System;
using System.Linq;

namespace _08StrategyPattern
{
    public class DataStore
    {
        private int[] data;

        public DataStore(int[] data)
        {
            this.data = data;
        }

        public int SumOfOdd()
        {
            var sum = 0;
            foreach (var d in data)
            {
                // We look for odd numbers.
                if (d % 2 == 1)
                {
                    sum += d;
                }
            }

            // with linq looks like:
            //return data.Sum( x => x % 2 == 1 );

            return sum;
        }

        public int ProductOfEven()
        {
            var prod = 1;

            foreach (var d in data)
            {
                if (d % 2 == 0)
                {
                    prod *= d;
                }
            }

            return prod;
        }
    }
}