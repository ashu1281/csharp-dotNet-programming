﻿using System.Collections;

namespace csharp_programming {
    public class Book {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Library : IEnumerable<Book> {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) {
            books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator() {
            return new LibraryEnumerator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        private class LibraryEnumerator : IEnumerator<Book> {
            private List<Book> books;
            private int index = -1;

            public LibraryEnumerator(List<Book> books) {
                this.books = books;
            }

            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose() {
                // No resources to dispose.
            }

            public bool MoveNext() {
                index++;
                return (index < books.Count);
            }

            public void Reset() {
                index = -1;
            }
        }
    }

    class Program {
        public static void Main() {
            // Create a list of Book objects
            Library library = new Library();
            library.AddBook(new Book() { Name = "A Fine Balance", Price = 215 });
            library.AddBook(new Book() { Name = "The Guide", Price = 158 });
            library.AddBook(new Book() { Name = "Fasting, Feasting", Price = 258 });

            foreach (Book b in library) {
                Console.WriteLine("Book Name: {0}, Book Price: {1}", b.Name, b.Price);
            }

            IEnumerable booksCollection = library;

            foreach (Book b in booksCollection) {
                Console.WriteLine("Book Name: {0}, Book Price: {1}", b.Name, b.Price);
            }
        }
    }
}

/*
 * The IEnumerable interface provides a way to iterate over a collection of objects and 
 * allows instances of a class to be enumerated using a foreach loop.
 */