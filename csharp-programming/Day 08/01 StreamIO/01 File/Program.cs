using System.IO;

namespace cshar_programming
{
    internal class Program
    {
        public static void Main()
        {
            string fileName = "a.txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }


            File.WriteAllText(fileName, "Hello, World");
            File.AppendAllText(fileName, "\n");
            File.AppendAllText(fileName, "hello world");


            string fileName2 = "b.txt";

            if (File.Exists(fileName2))
            {
                File.Delete(fileName2);
            }

            File.Copy(fileName, fileName2);
        }
    }
}
