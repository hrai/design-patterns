
using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class DinnerEnumerator: IEnumerator<Dish>
    {
        private Dish[] menuItems;
        private int position;

        public DinnerEnumerator(Dish[] menuItems)
        {
            this.menuItems = menuItems;
            position=0;
        }

        public bool MoveNext()
        {
            if(position < menuItems.Length && menuItems[position] != null)
            {
                return true;
            }

            return false;
        }

        void IEnumerator.Reset() => throw new NotImplementedException();

        void IDisposable.Dispose() { }

        object IEnumerator.Current
        {
            get {throw new NotImplementedException();}
        }

        Dish IEnumerator<Dish>.Current
        {
            get {return menuItems[position++];}
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

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

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DinnerEnumerator() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
