namespace HomeWork3
{
    class Author
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Author(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
            => Name + " " + LastName;
    }
}
