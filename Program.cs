using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Alice", 30, "123 Main St");
        Person person2 = new Person("Bob", 25, "456 Elm St");

        Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}, Address: {person1.Address}");
        Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}, Address: {person2.Address}");
    }
}
