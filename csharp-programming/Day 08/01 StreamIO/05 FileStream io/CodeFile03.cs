using System.Text;

namespace csharp_programming
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                FileStream booksFile = new FileStream("books.txt", FileMode.Open, FileAccess.ReadWrite);

                Book book = new Book() { Name = "Rich Dad,Poor Dad", Price = 375 };
                string s = string.Format("{0, -20} {1, 10:F2}", book.Name, book.Price);
                UTF8Encoding e = new UTF8Encoding();
                byte[] bytes = e.GetBytes(s);
                int byteCount = e.GetByteCount("A") * 31;

                booksFile.Seek(byteCount, SeekOrigin.Begin);
                booksFile.Write(bytes, 0, bytes.Length);

                booksFile.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("An Io exception has been occured");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                return;
            }
        }
    }
}