﻿using System.Runtime.InteropServices;

namespace csharp_Programming
{
    internal class Program
    {
        public static dynamic Add(dynamic u, dynamic v)
        {
            return u + v;
            
        }
        public static void Main() {
            int u = 1, v = 2, w = 0;
            w = Add(u, v);

            double i = 1.2, j = 2.3, k = 0.0;
            k = Add(i, j);
        } 
    }
}
