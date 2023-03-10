namespace csharp_programming
{
    internal class DummyBase : IDisposable
    {
        private bool disposed;

        public DummyBase()
        {
            Console.WriteLine("From Base Constructor");
        }

        ~DummyBase()
        {
            this.Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("From DummyBase.Dispose");

            if (!this.disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here, if any
                }

                // Dispose undisposed unmanaged resources here
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Foo()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException("DummyBase");
            }
        }
    }
}