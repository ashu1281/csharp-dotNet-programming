using System;

namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        public new void Print() //there is nothing to be reffer from base func by using new keyword instead of override.
        {
            Console.WriteLine("From DummyDerived.Print");

        }
    }
}
