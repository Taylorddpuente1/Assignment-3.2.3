// Tues, April 22, 2025
//Assignment 3.2.3 -Overload "+" and "-" operator for adding the areas of 2 circles and getting their area difference respectively

using System;
namespace MyApplication
{
    class Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public static double operator +(Circle c1, Circle c2)
        {
            return c1.Area() + c2.Area();
        }

        public static double operator -(Circle c1, Circle c2)
        {
            return Math.Abs(c1.Area() - c2.Area());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of first circle: ");
            double r1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter radius of second circle: ");
            double r2 = Convert.ToDouble(Console.ReadLine());

            Circle circle1 = new Circle(r1);
            Circle circle2 = new Circle(r2);

            Console.WriteLine($"\nArea of Circle 1: {circle1.Area():F2}");
            Console.WriteLine($"Area of Circle 2: {circle2.Area():F2}");

            double sum = circle1 + circle2;
            double difference = circle1 - circle2;

            Console.WriteLine($"\nSum of Areas: {sum:F2}");
            Console.WriteLine($"Difference of Areas: {difference:F2}");
        }
    }
}