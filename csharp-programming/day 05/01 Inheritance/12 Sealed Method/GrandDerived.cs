using System;

namespace csharp_programming
{
    internal class GrandDerived : DummyDerived
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("From GrandDerived.Print");
        }
    }
}
