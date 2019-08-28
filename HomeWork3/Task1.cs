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

            var book3 = new Book("Mark3", "Twain3", "The Adventures of Huckleberry Finn", "some text3");
            library.AddBook(book3);

            library.RemoveBook(book3);

            library.PrintListOfBooks();
        }
    }
}
