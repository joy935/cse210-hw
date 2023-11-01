using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Red", 5);
        Console.WriteLine($"Color: {square.GetColor()} - Area: {square.GetArea()}");
    }
}