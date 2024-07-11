using System;

namespace C42_G04_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commented out the code for the first question
            // Part01_CalculateDistance();

            // Call the method to find the oldest person
            Part01_FindOldestPerson();
        }

        #region Part 1 - Question 1 : Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

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

        #region Part 1 - Question 2: .Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
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

        #endregion
    }
}
