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

            var book2 = new Book(author, "Anna Karenina", "some text");
            library.AddBook(book2);

            library.PrintListOfBooks();
        }
    }
}
