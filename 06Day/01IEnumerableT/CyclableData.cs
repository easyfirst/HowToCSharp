using System;
using System.Collections.Generic;

namespace _01IEnumerableT
{
    /// <summary>
    /// Data packets to store and maintain a capable class, which
    /// enabling data packets to be crawled with the foreach cycle.
    /// 
    /// You can use any type of data using a generic definition. (strictly standard mode)
    /// </summary>
    public class CyclableData
    {
        List<Data> datasets = new List<Data>();

        #region Data maintenance interface.
        /// <summary>
        /// It adds an item (Data) to our list.
        /// </summary>
        /// <param name="data"></param>
        public void Add(Data data)
        {
            datasets.Add(data);
        }

        /// <summary>
        /// It removes an item (Data) from our list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Remove(Data data)
        {
            return datasets.Remove(data);
        }
        #endregion Data maintenance interface.

    }
}