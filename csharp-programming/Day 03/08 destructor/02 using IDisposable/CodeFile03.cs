using System;

namespace csharp_programming {
    class Dummy : IDisposable {
        private bool disposed;

        public Dummy() { }

        ~Dummy() {
            this.Dispose(false);
        }

        protected virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    // Dispose IDisposable managed resources here
                }
                // Dispose unmanaged resources here
                this.disposed = true;
            }
        }

        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DummyMember() {
            if (this.disposed) {
                throw new ObjectDisposedException("Dummy");
            }
        }
    }

    class Program {
        static void Main() {
            using (Dummy dummy = new Dummy()) {
                //dummy = new Dummy(); // Error: using variable is readonly variable
                dummy.DummyMember(); // OK: state of the object can be modified
            }
        }
    }
}

/*
 * Within the using block, the object is read-only and can't be modified or reassigned.
 * A variable declared with a using declaration is read-only.
 */