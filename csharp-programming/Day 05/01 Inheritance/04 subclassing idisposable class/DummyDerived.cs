namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        private bool disposed;

        public DummyDerived()
        {
            Console.WriteLine("From Derived Constructor");
        }

        ~DummyDerived()
        {
            this.Dispose(false);
        }

        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("From DummyDerived.Dispose");

            if (!this.disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here, if any
                }

                // Dispose undisposed unmanaged resources here
                this.disposed = true;
            }
            base.Dispose(disposing);
        }

        public void Bar()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException("DummyBase");
            }
        }
    }
}