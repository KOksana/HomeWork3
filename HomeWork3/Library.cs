using System;
using System.Collections.Generic;

namespace HomeWork3
{
    class Library
    {
        private List<Book> _books;

        public Library()
        {
            _books = new List<Book>
            {
                new Book(new Author("William", "Shakespeare"), "Hamlet", "some text"),
                new Book(new Author("William1", "Shakespeare1"), "King Lear", "some text"),
                new Book("George", "Orwell", "Nineteen Eighty Four", "some text"),
                new Book("Marcel", "Proust", "In Search of Lost Time", "some text")
            };
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            var index = _books.IndexOf(book);
            if (index != -1) _books.RemoveAt(index);
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
