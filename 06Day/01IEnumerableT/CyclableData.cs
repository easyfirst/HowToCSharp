using System;
using System.Collections;
using System.Collections.Generic;

namespace _01IEnumerableT
{
    /// <summary>
    /// Data packets to store and maintain a capable class, which
    /// enabling data packets to be crawled with the foreach cycle.
    /// 
    /// You can use any type of data using a generic definition. (strictly standard mode)
    /// 
    /// The own crawler class also implements the IEnumerable<T> interface.
    /// 
    /// The own crawler class also implements the IEnumerator<T> interface.
    /// 
    /// </summary>
    /// <typeparam name="TData">
    /// Storing and maintaining data type like this. It must be given at building time.
    /// </typeparam>
    public class CyclableData<TData> : IEnumerable<TData>, IEnumerator<TData>
    {
        List<TData> datasets = new List<TData>();

        #region Data maintenance interface.
        /// <summary>
        /// It adds an item (Data) to our list.
        /// </summary>
        /// <param name="data"></param>
        public void Add(TData data)
        {
            datasets.Add(data);
        }

        /// <summary>
        /// It removes an item (Data) from our list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Remove(TData data)
        {
            return datasets.Remove(data);
        }
        #endregion Data maintenance interface.


        #region IEnumerable<TData> implementation
        public IEnumerator<TData> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        #endregion IEnumerable<TData> implementation


        #region IEnumerator<TData> implementation
        public TData Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion IEnumerator<TData> implementation
    }
}