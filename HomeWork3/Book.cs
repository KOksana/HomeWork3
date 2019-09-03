namespace HomeWork3
{
    class Book
    {
        public Author Author { get; private set; }
        public string Name { get; private set; }
        public string Text { get; private set; }

        public Book(string authorName, string authorLastName, string bookName, string text)
        {
            Author = new Author(authorName, authorLastName);
            Name = bookName;
            Text = text;
        }

        public Book(Author author, string bookName, string text)
        {
            Author = author;
            Name = bookName;
            Text = text;
        }

        public override string ToString()
            => Name + ", " + Author;
    }
}
