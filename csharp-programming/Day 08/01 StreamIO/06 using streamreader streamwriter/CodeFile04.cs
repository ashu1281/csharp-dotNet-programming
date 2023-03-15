using System;
using System.IO;
using System.Threading;

namespace cshar_programming
{
    class program
    {
        public static void Main()
        {
            try
            {
                StreamReader sr = new StreamReader("a.txt");

                string s;
                s = sr.ReadToEnd();
                Console.WriteLine(s);

                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}