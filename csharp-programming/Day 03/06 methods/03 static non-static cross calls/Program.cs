using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    internal class Program
    {
        public void F() { }
        public static void G() { }  

        public void K() {
            F();
            G();
        }
        public static void M() {
            F();
            G();
        }
    }
}

/*
 * A non-static member can access another static and non-static member.
 * A static member can access only another static .
 */