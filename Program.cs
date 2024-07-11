﻿#region Struct
// A struct is a value type in C# that is typically used for small data structures that contain primarily data.
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Point p = new Point(10, 20);
        p.Display();  // Output: Point: (10, 20)
    }
}

#endregion

#region Encapsulation using Setter & Getter Methods
// Encapsulation is the process of wrapping data and methods into a single unit, typically a class, and restricting access to some of the object's components.

public class Person
{
    private string name;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.SetName("John");
        Console.WriteLine(person.GetName());  // Output: John
    }
}


#endregion

#region Encapsulation using Properties
// Properties provide a flexible mechanism to read, write, or compute the values of private fields.

public class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "John";
        Console.WriteLine(person.Name);  // Output: John
    }
}


#endregion

#region Indexer
// Indexers allow instances of a class or struct to be indexed just like arrays.

public class SampleCollection<T>
{
    private T[] arr = new T[100];

    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main()
    {
        var stringCollection = new SampleCollection<string>();
        stringCollection[0] = "Hello";
        Console.WriteLine(stringCollection[0]);  // Output: Hello
    }
}


#endregion

#region Class - Internal Constructor Chaining
// Constructor chaining is the process of one constructor calling another constructor within the same class.

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee() : this("Unknown", 0) { }

    public Employee(string name) : this(name, 0) { }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee();
        emp1.Display();  // Output: Name: Unknown, Age: 0

        Employee emp2 = new Employee("Alice");
        emp2.Display();  // Output: Name: Alice, Age: 0

        Employee emp3 = new Employee("Bob", 30);
        emp3.Display();  // Output: Name: Bob, Age: 30
    }
}


#endregion