using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()} - Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 10);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()} - Area: {rectangle.GetArea()}");
    }
}