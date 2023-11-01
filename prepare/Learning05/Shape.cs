using System;

public virtual class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public void Shape(string color)
    {
        SetColor(color);
    }

    public virtual double GetArea()
    {
        return 0;
    }
}