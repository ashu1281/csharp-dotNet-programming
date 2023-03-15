using System.IO;

namespace cshar_programming
{
    internal class Class1
    {
        public static void Main()
        {
            string fileName = "b.txt";
            FileInfo bInfo = new FileInfo(fileName);

            string directory = "temp";
            DirectoryInfo directoryinfo = new DirectoryInfo(directory);

            if (directoryinfo.Exists)
            {
                directoryinfo.Delete(true);
            }

            directoryInfo.Create();

            bInfo.MoveTo(directoryinfo.ToString() + @'\' + bInfo.ToString());


        }
    }
}
