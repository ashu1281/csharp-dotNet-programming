using System;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyDerived d = new DummyDerived(1,2);
        }
    }
}

/*
 * While installing derived class, the constructor of the base class is executed first 
 * and then the constructor of the derived class.

 */