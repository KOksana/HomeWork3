namespace HomeWork3
{
    class Book
    {
        public Author Author { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

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
