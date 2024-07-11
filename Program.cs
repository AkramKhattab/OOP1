#region Struct
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