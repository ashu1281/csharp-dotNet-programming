using System;

namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static Integer Add(Integer a, Integer b) {
            Integer c = new Integer {
                value = a.value + b.value
            };
            //a.value = 5;
            //b.value = 10; // here value of u and v will be modified.

            //a = new Integer { value = 5 };
            //b = new Integer { value = 10 }; // here value of u and v not modified

            return c;

        }

        static void Main() {
            Integer u = new Integer() { value = 1 };
            Integer v = new Integer() { value = 2 };
            Integer result = Add(u, v);
            Console.WriteLine($"Sum of {u.value} and {v.value} is {result.value}");
        }
    }
}
