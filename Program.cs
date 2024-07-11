using System;

namespace C42_G04_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the method to calculate the distance between two points
            Part01_CalculateDistance();
        }

        #region Part 01 - Question 1: Calculate the distance between two points

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

        #endregion
    }
}
