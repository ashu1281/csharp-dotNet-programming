using Microsoft.Win32.SafeHandles;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace csharp_programming {
    class Dummy : IDisposable {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);

        // Pointer to an external unmanaged resource.
        private IntPtr handle;

        // Other managed resource this class uses.
        private Component component = new Component();

        // Track whether Dispose has been called.
        private bool disposed = false;

        // The class constructor.
        public Dummy() {
            string fileName = "example.txt";
            uint desiredAccess = 0x80000000; // GENERIC_READ
            uint shareMode = 0x00000001; // FILE_SHARE_READ
            IntPtr securityAttributes = IntPtr.Zero;
            uint creationDisposition = 0x00000002; // OPEN_EXISTING
            uint flagsAndAttributes = 0x00000080; // FILE_ATTRIBUTE_NORMAL
            IntPtr templateFile = IntPtr.Zero;

            handle = CreateFile(
                fileName,
                desiredAccess,
                shareMode,
                securityAttributes,
                creationDisposition,
                flagsAndAttributes,
                templateFile);
        }

        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        public void Dispose() {
            Dispose(disposing: true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SuppressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool disposing) {
            // Check to see if Dispose has already been called.
            if (!this.disposed) {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing) {
                    // Dispose managed resources.
                    component.Dispose();
                }

                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.
                CloseHandle(handle);
                handle = IntPtr.Zero;

                // Note disposing has been done.
                disposed = true;
            }
        }

        // Use C# finalizer syntax for finalization code.
        // This finalizer will run only if the Dispose method
        // does not get called.
        // It gives your base class the opportunity to finalize.
        // Do not provide finalizer in types derived from this class.
        ~Dummy() {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(disposing: false) is optimal in terms of
            // readability and maintainability.
            Dispose(disposing: false);
        }

        void SomeFunction() {
            if (this.disposed) {
                throw new ObjectDisposedException("Dummy");
            }
            // SomeFunction code here
        }
    }

    class Program {
        static void Main() {
            Dummy dummy = new Dummy();
            dummy.Dispose();
            dummy = null;
        }
    }
}

/*
 * Rules to follow while implementing Dispose method:
 * 1. Dispose() must be callable multiple times, with no consequences.
 * 2. The type should also implement a finalizer,
 *    in order to protect the class from not freeing the resources if
 *    the caller does not call dispose properly.
 * 3. Dispose() should call GC.SuppressFinalize to prevent the finalizer
 *    from running once Dispose() has been called.
 * 4. Any method called after the call to Dispose() should throw
 *    an ObjectDisposedException.
 */
