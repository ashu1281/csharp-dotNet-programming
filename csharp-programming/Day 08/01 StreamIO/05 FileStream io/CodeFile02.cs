using System.Text;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                FileStream booksFile = new FileStream("book.txt", FileMode.Open, FileAccess.Read);

                List<Book> books = new List<Book>();
                UTF8Encoding e = new UTF8Encoding();
                int byteCount = e.GetByteCount("A") * 31;
                byte[] bytes = new byte[byteCount];

                do
                {
                    if (booksFile.Read(bytes, 0, byteCount) == 0)
                        break;
                    string bookData = e.GetString(bytes);
                    books.Add(new Book
                    {
                        Name = bookData.Substring(0, 20).Trim(),
                        Price = Convert.ToDouble(bookData.Substring(21))
                    });

                } while (true);

                booksFile.Close();

            }
            catch(IOException ex)
            {
                Console.WriteLine("an io exception has been thrown");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}