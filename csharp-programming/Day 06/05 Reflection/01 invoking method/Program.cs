using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args) {
            Assembly assembly = Assembly.LoadFrom("MathClassLibrary");
            Type mathType = assembly.GetType("MathClassLibrary.Math");
            MethodInfo addInfo = mathType.GetMethod("Add");
            object mathInstance = Activator.CreateInstance(mathType);
            int result = (int)addInfo.Invoke(mathInstance, new object[] { 10, 20 });

        }
    }
}
