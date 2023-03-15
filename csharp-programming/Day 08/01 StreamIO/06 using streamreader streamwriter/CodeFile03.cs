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

                int charData;
                charData = sr.Read();
                while (charData != -1)
                {
                    Console.Write(Convert.ToChar(charData));
                    charData = sr.Read();
                    Thread.Sleep(100);
                }
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}