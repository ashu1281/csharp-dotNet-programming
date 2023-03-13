using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
    
    public class Library : IEnumerable<Book> { 
        private List<Book> _library = new List<Book>();

        public void AddBook(Book book)
        {
            _library.Add(book);
        }

        public IEnumerator<Book> GetEnumerator() {
            return _library.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _library.GetEnumerator();
        }
    }
    class Program
    {
        public static void Main()
        {
            // Create a list of Book objects
            Library library = new Library();
            library.AddBook(new Book() { Name = "A Fine Balance", Price = 215 });
            library.AddBook(new Book() { Name = "The Guide", Price = 158 });
            library.AddBook(new Book() { Name = "Fasting, Feasting", Price = 258 });

            foreach (Book b in library)
            {
                Console.WriteLine("Book Name: {0}, Book Price: {1}", b.Name, b.Price);
            }

            IEnumerable booksCollection = library;

            foreach (Book b in booksCollection)
            {
                Console.WriteLine("Book Name: {0}, Book Price: {1}", b.Name, b.Price);
            }
        }
    }
}

/*
 * The IEnumerable interface provides a way to iterate over a collection of objects and 
 * allows instances of a class to be enumerated using a foreach loop.
 */