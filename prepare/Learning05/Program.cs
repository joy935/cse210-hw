using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Red", 5);
        Console.WriteLine($"Color: {square.GetColor()} - Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 10);
        Console.WriteLine($"Color: {rectangle.GetColor()} - Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 5);
        Console.WriteLine($"Color: {circle.GetColor()} - Area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} - Area: {shape.GetArea()}");
        }
    }
}