
using System.Data;

namespace cshar_programming
{
    internal class Program
    {
        public static void Main()
        {
            string directory = "temp";

            if(Directory.Exists(directory))
            {
                Directory.Delete(directory, true);
            }

            Directory.CreateDirectory(directory);


            File.Move("b.txt",directory + @'\' , "b.txt");
        }
    }
}
