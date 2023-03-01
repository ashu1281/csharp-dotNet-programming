using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            return 101;
        }
    }
}

/*
 * 'Main' is a function.
 * It is also an entry point function to C# program.
 * C# is case sensitive language, hence entry point function must be written as 'Main' and not in any other form.
 * Main can be defined as an entry point function in both class and struct.
 * For C# source to get compile:
 * - It is not compulsory for C# source file to end with extension .cs.
 * - It is not compulsory for C# source file to have name same as the public class contained in it.
 * If more than one class has Main method then use /main compiler switch to specify which Main
 * method to be selected as an entry point function.
 * Value returned from an entry point function is known as exit code and is stored in
 * ERRORLEVEL environment variable.
 */