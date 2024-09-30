using System;

class Author
{
    public string Name { get; set; }
    public int BirthYear { get; set; }

    public Author(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    public override string ToString()
    {
        return $"{Name}, born in {BirthYear}";
    }
}

class Book
{
    public string Title { get; set; }
    public int YearPublished { get; set; }
    public Author Author { get; set; }

    public Book(string title, int yearPublished, Author author)
    {
        Title = title;
        YearPublished = yearPublished;
        Author = author;
    }

    public override string ToString()
    {
        return $"'{Title}' by {Author}, published in {YearPublished}";
    }
}

class Program
{
    static void Main()
    {
        Author author1 = new Author("George Orwell", 1903);
        Author author2 = new Author("J.K. Rowling", 1965);

        Book book1 = new Book("1984", 1949, author1);
        Book book2 = new Book("Остров", 1997, author2);

        Console.WriteLine(book1);
        Console.WriteLine(book2);
    }
}