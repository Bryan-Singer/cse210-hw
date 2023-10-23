using System;

class Program3 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

public class Shape {
    private string _color;

    public Shape(string color) {
        _color = color;
    }

    // This would not work, the parameters are in the wrong place to do it. Area of a circle is different from an area of a square
    // public float Area() {

    // }
}

public class Circle: Shape {
    private float _radius;

    public Circle(string color, float radius) : base(color) {
        _radius = radius;
    }

    public float Area() {
        float pi = (float)3.14;
        return pi * _radius * _radius;
    }
}

public class Square: Shape {
    private float _sidelength;

    public Square(string color, float sidelength) : base(color) {
        _sidelength = sidelength;
    }

    public float Area() {
        return _sidelength * _sidelength;
    }
}