﻿namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        public sealed override void Print()
        {
            //base.Print();//cannot call abstract base member.
            Console.WriteLine("From DummyDerived.Print");

        }
    }
}
