namespace csharp_programming {
    public class MyClass<T> where T : new() {
        public T CreateInstance() {
            return new T();
        }
    }

    class Foo {
        public Foo(int n) { }
    }

    class Bar {
        public Bar() { }
    }

    class Program {
        static void Main(string[] args) {
            MyClass<Foo> obj = new MyClass<Foo>();
            MyClass<Bar> obj2 = new MyClass<Bar>();
        }
    }
}

/*
 * 'new' constraint insists that type should have default constructor.
 * When used together with other constraints, the new constraint must be specified last.
 */