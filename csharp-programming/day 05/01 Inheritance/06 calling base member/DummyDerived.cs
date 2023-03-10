using System;

namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        public override void Print()
        {
            base.Print();//it call print of its base class.
            Console.WriteLine("From DummyDerived.print");

        }
    }
}
