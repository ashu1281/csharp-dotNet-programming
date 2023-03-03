namespace csharp_programming {
    class Dummy {
        public Dummy() {
            // code to consume native/unmanaged resource
        }
        ~Dummy() {
            // code to release native/unmanaged resource
        }
    }
    class Program {
        static void Main() {
            Dummy dummy = new Dummy();
            dummy = null; // doesn't invoke destructor
            GC.Collect();
        }
    }
}