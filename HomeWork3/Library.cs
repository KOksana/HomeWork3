using System;
using System.Collections.Generic;

namespace HomeWork3
{
    class Library
    {
        private List<Book> _books;
        private Author _author = new Author("William", "Shakespeare");

        public Library()
        {
            _books = new List<Book>
            {
                new Book(_author, "Hamlet", "some text"),
                new Book(_author, "King Lear", "some text"),
                new Book("George", "Orwell", "Nineteen Eighty Four", "some text"),
                new Book("Marcel", "Proust", "In Search of Lost Time", "some text")
            };
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void PrintListOfBooks()
        {
            Console.WriteLine("--- List of books in the Library ---");

            foreach (var book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
