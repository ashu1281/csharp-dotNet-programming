
namespace cshar_programming
{
    internal class Class1
    {
        public static void Main()
        {
            string filename = "a.txt";
            FileInfo aInfo = new FileInfo(filename);

            if (aInfo.Exists)
            {
                aInfo.Delete();
            }

            StreamWriter sw= aInfo.AppendText();
            sw.WriteLine("Hello , world");
            sw.WriteLine("Hi there");
            sw.Close();


            string filename2 = "b.txt";
            FileInfo bInfo = new FileInfo(filename2);

            if (bInfo.Exists)
            {
                bInfo.Delete();
            }

            aInfo.CopyTo(filename2);

        }
    }
}
