using System.Runtime.CompilerServices;

namespace csharp_programming
{
    class FileException : Exception
    {
        public int Cause { get; set; }

        public const int FileNotFoundException = 1;
        public const int BadPath = 2;
        public const int DiskFull = 3;

        public FileException(int cause) : base(GetMessage(cause))
        {
            Cause = cause;
        }
        
        private static string GetMessage(int cause)
        {
            string message = null;
            switch (cause)
            {
                case FileNotFoundException:
                    message = "File Not Found";
                    break;
                case BadPath:
                    message = "Invalid Path";
                    break;
                case DiskFull:
                    message = "Disk is full";
                    break;
            }
            return message;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if(!File.Exists("example.txt"))
                    throw new FileException(FileException.FileNotFoundException);

                if (!Directory.Exists("X:\\temp"))
                    throw new FileException(FileException.BadPath);
            }
            catch(FileException e) when (e.Cause == FileException.FileNotFoundException)
            {
                File.Create("example.txt");
            }
            catch(FileException e) when (e.Cause == FileException.BadPath)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

/*
 * Exception filters was introduced in C# 6.0.
 * It adds additional conditions on the catch block. 
 * The condition must evaluate to true for the catch
 * block to handle the exception.
 */