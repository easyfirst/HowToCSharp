using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace _01IDisposable
{
    /// <summary>
    /// This is a class which cleans everything self
    /// with help of inclusive IDisposable interface after if itself will destroy.
    /// </summary>
    public class ItselfCleaner : IDisposable
    {
        private bool isDisposed = false;

        //managed stream but implements IDisposable interface
        private Stream fileStream = new FileStream("file.txt", FileMode.Create);
        //managed list, but large
        private List<string> managedMemory = new List<string>();
        //unmanaged memory space
        private IntPtr unmanagedMemory = IntPtr.Zero;

        public ItselfCleaner()
        {
            //filling up managed memory
            for (int i = 0; i < 1000000; i++)
            {
                managedMemory.Add("AAAAAAA");
            }

            //reservations of unmanaged memory
            unmanagedMemory = Marshal.AllocHGlobal(1000000);
            //because it is unmanaged memory, so we say to GC not to use this memory
            GC.AddMemoryPressure(1000000);
        }

        /// <summary>
        /// This function does the cleaning event.
        /// In the function of 'Dispose()' it is not enabled causing an exception.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            // It takes this class out from Finalizer queue.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The finalizer of this class. If there is no pointer to point to this object,
        /// then it runs sometime.
        /// </summary>
        ~ItselfCleaner()
        {
            Dispose(false);
        }

        /// <summary>
        /// It's the 'real' cleaner function.
        /// </summary>
        /// <param name="dispose">This indicates whether it is called from the 'Dispose ()' (true) function or
        /// 'Finalizer ()' (false) function.</param>
        private void Dispose(bool dispose)
        {
            if (isDisposed)
            {
                return;
            }

            //cleaning

            if (dispose)
            { //it is called from the 'Dispose ()' function, so the managed parts have to be cleaned.

                //release an instance using a managed IDisposable interface
                // observing the null value not to get exception 
                if (fileStream != null)
                {
                    fileStream.Dispose();
                    fileStream = null;
                }

                //release a managed memory
                if (managedMemory != null)
                {
                    managedMemory.Clear();
                    managedMemory = null;
                }

            }

            // observing the zero value (uninitialized) not to get exception
            if (unmanagedMemory != IntPtr.Zero)
            {
                //release an unmanaged memory
                Marshal.FreeHGlobal(unmanagedMemory);
                //we say to GC this memory is usable
                GC.RemoveMemoryPressure(1000000);
            }

            isDisposed = true;
        }
    }
}