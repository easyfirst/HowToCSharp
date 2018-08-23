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
            if (isDisposed)
            {
                return;
            }

            //cleaning

            //release an instance using a managed IDisposable interface
            fileStream.Dispose();
            fileStream = null;

            //release a managed memory
            managedMemory.Clear();
            managedMemory = null;

            //release an unmanaged memory
            Marshal.FreeHGlobal(unmanagedMemory);
            //we say to GC this memory is usable
            GC.RemoveMemoryPressure(1000000);

            isDisposed = true;
        }

        ~ItselfCleaner()
        {
            Dispose();
        }
    }
}