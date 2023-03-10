namespace csharp_programming
{
    class Base { }

    class Derived1 : Base
    {
        public void F() { }
    }

    class Derived2 : Base
    {
        public void G() { }
    }

    class Program
    {
        static void Main()
        {
            Base b = new Derived1();

            if (b is Derived1)
            {
                Derived1 d = b as Derived1;
                d.F();
            }
            else if (b is Derived2)
            {
                Derived2 d = b as Derived2;
                d.G();
            }
        }
    }
}

/*
 * - The is operator checks if the result of an expression is compatible with a given type.
 */