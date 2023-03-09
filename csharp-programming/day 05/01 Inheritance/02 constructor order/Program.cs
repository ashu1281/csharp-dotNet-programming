
using csharp_programming.day_05._01_Inheritance._01_basic_class_inheritance_syntax;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyDerived d = new DummyDerived();
        }
    }
}

/*
 * While installing derived class, the constructor of the base class is executed first 
 * and then the constructor of the derived class.

 */