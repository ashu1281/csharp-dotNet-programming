namespace csharp_Programming
{
    class Dummy { }
    class Program
    {
        static void Main() { 
            //Dummy dummy = new Dummy(); //early binding
            dynamic dummy = new Dummy();//late binding
            dummy.Foo();
        } 
    }
}

/*
 * C# 4 introduce a new type called dynamic.
 * 'dynamic' is a kind of late binding in C#.
 * 'dynamic' defers member call resolution to runtime rather than compile-time.
 * early binding is faster than late binding.bz it perform at compile time not runtime like late binding.
 */