using System;

namespace HomeWork3
{
    class Task1
    {
        public static void Processing()
        {
            var library = new Library();

            var author = new Author("Leo", "Tolstoy");

            var book1 = new Book(author, "War and Peace", "some text");
            library.AddBook(book1);

            var book2 = new Book("Mark", "Twain", "The Adventures of Huckleberry Finn", "some text");
            library.AddBook(book2);

            library.AddBook(book2);

            library.PrintListOfBooks();
            
            library.RemoveDuplicates();

            Console.WriteLine("\n*** Without duplicates ***");
            library.PrintListOfBooks();
        }
    }
}
