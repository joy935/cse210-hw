using System;

public class Square : Shape
{
    private double _side;

    public void Square(string color, double side) : base(color)
    {
        _side = side;
    }
    {
        
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}