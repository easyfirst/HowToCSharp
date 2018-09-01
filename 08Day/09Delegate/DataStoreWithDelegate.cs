using System;

namespace _09Delegate
{
    public class DataStoreWithDelegate
    {
        private int[] data;

        //It's a function definition which declare
        // - the name of function (This name can be used to refer to the function in the program.)
        // - the type of return value
        // - the arguments.
        public delegate int ProcessDef(int[] data);

        public DataStoreWithDelegate(int[] data)
        {
            this.data = data;
        }

        #region 1. type of using delegate
        public int Process(ProcessDef strategy)
        {
            return strategy(data);
        }
        #endregion 1. type of using delegate


        #region 2. type of using delegate
        public int Process2(Func<int[], int> strategy)
        {
            return strategy(data);
        }

        #endregion 2. type of using delegate


        #region 3. type of using delegate
        internal int Process3(Func<int[], int> strategy)
        {
            return strategy(data);
        }
        #endregion 3. type of using delegate
    }
}