namespace csharp_programming {
    class Book {
        public string Name { get; set; }
        public string ISBN { get; set; }
    }

    class Library {
        List<Book> books;

        public Library() {
            books = new List<Book>();
            books.Add(new Book { Name = "A Fine Balance", ISBN = "0-679-44608-7" });
            books.Add(new Book { Name = "The Guide", ISBN = "	0-670-35668-9" });
            books.Add(new Book { Name = "The Inheritance of Loss", ISBN = "0-241-14348-9" });
            books.Add(new Book { Name = "Fasting, Feasting", ISBN = "0-618-06582-2" });
            books.Add(new Book { Name = "The Namesake", ISBN = "0-395-92721-8" });
        }

        public int Count {
            get { return books.Count; }
        }

        public Book this[int index] {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public Book this[string isbn] {
            get {
                foreach (var book in books) {
                    if (book.ISBN == isbn)
                        return book;
                }
                return null;
            }
        }
    }

    class Program {
        static void Main() {
            Library library = new Library();

            // Accessing books, by position
            for (int i = 0; i < library.Count; i++) {
                Console.WriteLine(library[i].Name);
            }

            // Accessing book by ISBN
            Console.WriteLine(library["0-241-14348-9"].Name);
        }
    }
}

/*
 * Note indexers can be overloaded.
 */
