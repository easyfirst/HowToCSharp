using System;

namespace _08StrategyPattern
{
    public class DataStoreWithStrategy
    {
        private int[] data;
        private sumOfOddStrategy strategy;

        public DataStoreWithStrategy(int[] data)
        {
            this.data = data;
        }

        public int Process()
        {
            return strategy.Process(data);
        }

        public void SetStrategy(sumOfOddStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}