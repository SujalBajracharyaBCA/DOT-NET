/* Define an abstract class Shape with abstract method CalculateSurface() and fields width and height .
Define two additional classes for a triangle and a rectangle , which implement CalculateSurface() . 
This method has to return the areas of the rectangle (height * width) and the triangle (height * width / 2) .
Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width)
with the same value (the radius) and implement the abstract method for calculating the area. 
Create an array of different shapes and calculate the area of each shape in another array. */

using System;

namespace Lab6
{
    // Abstract class 
    public abstract class Shape
    {
        // Fields
        protected double width;
        protected double height;

        // Constructor
        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Abstract method
        public abstract double CalculateSurface();
    }

    // Rectangle class inheriting from Shape
    public class Rectangle : Shape
    {
        // Constructor
        public Rectangle(double width, double height) : base(width, height) { }

        // Implementing CalculateSurface method
        public override double CalculateSurface()
        {
            return width * height;
        }
    }

    // Triangle class inheriting from Shape
    public class Triangle : Shape
    {
        // Constructor
        public Triangle(double width, double height) : base(width, height) { }

        // Implementing CalculateSurface method
        public override double CalculateSurface()
        {
            return (width * height) / 2;
        }
    }

    // Circle class inheriting from Shape
    public class Circle : Shape
    {
        // Constructor
        public Circle(double radius) : base(radius, radius) { }

        // Implementing CalculateSurface method
        public override double CalculateSurface()
        {
            return Math.PI * height * width; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array of different shapes
            Shape[] shapes = new Shape[]
            {
                new Rectangle(6, 12),
                new Triangle(12, 4),
                new Circle(7)
            };

            // Calculating and displaying the area of each shape
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"The area of the {shape.GetType().Name} is: {shape.CalculateSurface()}");
            }
        }
    }
}
