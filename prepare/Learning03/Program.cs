using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(6,7);

        f1.SetTop(5);
        Console.WriteLine(f1.GetTop());
        f2.SetTop(6);
        f2.SetBottom(7);
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f2.GetBottom());
        
    }
}