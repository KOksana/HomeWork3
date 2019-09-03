namespace HomeWork3
{
    class Author
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Author(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
            => Name + " " + LastName;
    }
}
