using System.Text;

namespace csharp_programming
{ 
    internal class codeFile01
    {
        public static void Main()
        {
            try
            {
                Book[] books = new Book[]
                {
                    new Book(){Name="A fine Balance",Price=215},
                    new Book(){ Name="A Guide", Price=158},
                    new Book(){Name="Fasting,Featuring",Price=160}
                };

                FileStream booksFile = new FileStream("book.txt", FileMode.Create, FileAccess.Write);

                UTF8Encoding e = new UTF8Encoding();
                foreach(Book book in books)
                {
                    string s = string.Format("{0,-20} {1,10:f2}", book.Name, book.Price);
                    byte[] bytes = e.GetBytes(s);
                    booksFile.Write(bytes, 0, bytes.Length);
                }

                booksFile.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Io exception has been thrown");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                return;

            }
        }
    }
}
