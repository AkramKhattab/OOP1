namespace C42_G04_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment the method calls as needed
            // Part01_CalculateDistance();
            // Part01_FindOldestPerson();
        }

        #region Part 1 - Question 1: Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

        /*
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double DistanceTo(Point other) =>
                Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        }

        public static void Part01_CalculateDistance()
        {
            Console.WriteLine("Enter the coordinates for Point 1 (x y): ");
            var point1Input = Console.ReadLine().Split();
            var point1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

            Console.WriteLine("Enter the coordinates for Point 2 (x y): ");
            var point2Input = Console.ReadLine().Split();
            var point2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

            var distance = point1.DistanceTo(point2);
            Console.WriteLine($"The distance between the points is: {distance}");
        }
        */
        #endregion

        #region Part 1 - Question 2: Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        /*
        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        public static void Part01_FindOldestPerson()
        {
            var persons = new Person[3];

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for Person {i + 1} (Name Age): ");
                var personInput = Console.ReadLine().Split();
                persons[i] = new Person(personInput[0], int.Parse(personInput[1]));
            }

            var oldest = persons[0];

            foreach (var person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}");
        }
        */
        #endregion

        #region Part 2 - Question 1: Design and implement a Class for the employees in a company.

        // Enum for security privileges
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }

        // Class for Hire Date
        public class HireDate : IComparable<HireDate>
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public int CompareTo(HireDate other)
            {
                if (Year != other.Year)
                    return Year.CompareTo(other.Year);
                if (Month != other.Month)
                    return Month.CompareTo(other.Month);
                return Day.CompareTo(other.Day);
            }

            public override string ToString() => $"{Day:00}/{Month:00}/{Year:0000}";
        }

        // Class for Employee
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public SecurityLevel SecurityLevel { get; set; }
            public decimal Salary { get; set; }
            public HireDate HireDate { get; set; }
            public char Gender { get; set; }

            public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, char gender)
              : this(id, name, securityLevel, salary, hireDate) // Call another constructor for common initialization
            {
                Gender = gender; // Validate and set gender in separate step
            }

            public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate)
            {
                ID = id;
                Name = name;
                SecurityLevel = securityLevel;
                Salary = salary;
                HireDate = hireDate;
            }

            public override string ToString() => $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
        }

        #endregion
    }
}
