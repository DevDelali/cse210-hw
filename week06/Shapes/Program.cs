using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5.0, "Green"));
        shapes.Add(new Square(4.0, "Red"));
        shapes.Add(new Circle(2.5, "Blue"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The  {shape.GetColor()} shape has an area of {shape.GetArea():.00}\n");
        }
    }
}