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
        int position = -1;

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

        /// <summary>
        /// The crawler is also implemented by this class so we can return with 'this' instance.
        /// </summary>
        /// <returns>CyclableData instance, which contains the simple datas.</returns>
        public IEnumerator<TData> GetEnumerator()
        {
            return this;
        }

        /// <summary>
        /// The 'IEnumerator' prefix helps distinguish between the same property getter of two surface.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        #endregion IEnumerable<TData> implementation


        #region IEnumerator<TData> implementation

        /// <summary>
        /// It returns with the actual item.
        /// </summary>
        public TData Current { get { return datasets[position]; } }

        /// <summary>
        /// Because the function is already implemented generically, you just have to call it.
        /// 
        /// The 'IEnumerator' prefix helps distinguish between the same property getter of two surface.
        /// </summary>
        object IEnumerator.Current { get { return Current; } }

        public bool MoveNext()
        {
            position++;

            return position < datasets.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Because the generic class always contains another class type, it may be IDisposable and may not.
        /// You can only prepare for this by implementing the IDisposable interface first.
        /// </summary>
        public void Dispose()
        {
            //because now we do not have to clean up, so we do not have to implement it.
        }
        #endregion IEnumerator<TData> implementation
    }
}