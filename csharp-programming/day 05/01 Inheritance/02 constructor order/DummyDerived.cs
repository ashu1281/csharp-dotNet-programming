using csharp_programming.day_05._01_Inheritance._01_basic_class_inheritance_syntax;
using System;

namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        public DummyDerived() {
            Console.WriteLine("From DummyDerived Constructor");
        }
    }
}
