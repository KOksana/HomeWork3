﻿using System;
using System.Collections.Generic;
using System.Linq;

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
                new Book(new Author("William", "Shakespeare"), "King Lear", "some text"),
                new Book("George", "Orwell", "Nineteen Eighty Four", "some text"),
                new Book("Marcel", "Proust", "In Search of Lost Time", "some text")
            };
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveDuplicates()
        {
            _books =_books.Distinct().ToList();
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
