using System;
using System.Collections;
using System.Collections.Generic;

namespace Furcadia.Net
{
    /// <summary>
    /// Furre List information for a Furcadia Dream
    /// <para>
    /// This class acts like an enhanced List(of &gt;T&lt;) because you can Select a Furre by Item as
    /// well as index
    /// </para>
    /// </summary>
    public class FURREList : ICollection, IDisposable, IEnumerator<FURRE>
    {
        /// <summary>
        /// </summary>
        protected internal List<FURRE> fList;

        /// <summary>
        /// </summary>
        public FURREList()
        {
            fList = new List<FURRE>();
        }

        /// <summary>
        /// </summary>
        public int Count
        {
            get
            {
                return ((ICollection)fList).Count;
            }
        }

        /// <summary>
        /// </summary>
        public FURRE Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// </summary>
        public bool IsSynchronized
        {
            get
            {
                return ((ICollection)fList).IsSynchronized;
            }
        }

        /// <summary>
        /// </summary>
        public object SyncRoot
        {
            get
            {
                return ((ICollection)fList).SyncRoot;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <returns>
        /// </returns>
        public FURRE this[
            int index
        ]
        { get { return fList[index]; } set { fList[index] = value; } }

        /// <summary>
        /// </summary>
        /// <param name="Furre">
        /// </param>
        /// <returns>
        /// </returns>
        public FURRE this[
    FURRE Furre
]
        { get { return fList[fList.IndexOf(Furre)]; } set { fList[fList.IndexOf(Furre)] = value; } }

        /// <summary>
        /// </summary>
        /// <param name="Furre">
        /// </param>
        public void add(FURRE Furre)
        {
            fList.Add(Furre);
        }

        /// <summary>
        /// add a range of Furres to the list
        /// </summary>
        /// <param name="range">
        /// </param>
        public void AddRange(IEnumerable<FURRE> range)
        {
            fList.AddRange(range);
        }

        /// <summary>
        /// </summary>
        public void Clear()
        {
            fList.Clear();
        }

        /// <summary>
        /// </summary>
        /// <param name="FurreID">
        /// </param>
        /// <returns>
        /// </returns>
        public bool Contains(int FurreID)
        {
            return fList.Contains(new Net.FURRE(FurreID));
        }

        /// <summary>
        /// </summary>
        /// <param name="Furre">
        /// </param>
        /// <returns>
        /// </returns>
        public bool Contains(FURRE Furre)
        {
            return fList.Contains(Furre);
        }

        /// <summary>
        /// </summary>
        /// <param name="array">
        /// </param>
        /// <param name="index">
        /// </param>
        public void CopyTo(Array array, int index)
        {
            ((ICollection)fList).CopyTo(array, index);
        }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            return ((ICollection)fList).GetEnumerator();
        }

        /// <summary>
        /// </summary>
        /// <param name="Furre">
        /// </param>
        /// <returns>
        /// </returns>
        public int IndexOf(FURRE Furre)
        {
            return fList.IndexOf(Furre);
        }

        /// <summary>
        /// Removes a Furre based on their Furre ID
        /// </summary>
        /// <param name="FurreID">
        /// </param>
        public void Remove(int FurreID)
        {
            fList.Remove(new Net.FURRE(FurreID));
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above. GC.SuppressFinalize(this);
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free
        //       unmanaged resources. ~FURREList() { // Do not change this code. Put cleanup code in
        // Dispose(bool disposing) above. Dispose(false); }

        /// <summary>
        /// </summary>
        /// <returns>
        /// </returns>
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="disposing">
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        #endregion IDisposable Support
    }
}