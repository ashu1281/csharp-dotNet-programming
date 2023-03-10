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
            bool result = false;
            result = b is Derived1; // true
            result = b is Derived2; // false
        }
    }
}