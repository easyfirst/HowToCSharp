namespace _08StrategyPattern
{
    /// <summary>
    /// Closed in this class we implement the addition of odd numbers.
    /// </summary>
    public class sumOfOddStrategy : IStrategy
    {

        public int Process(int[] data)
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
    }
}