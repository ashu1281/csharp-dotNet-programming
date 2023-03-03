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
            using (Dummy dummy = new Dummy(), dummy2 = new Dummy()) {

            }
        }
    }
}

/*
 * Multiple instances of a type can be declared in a single using statement.
 */
