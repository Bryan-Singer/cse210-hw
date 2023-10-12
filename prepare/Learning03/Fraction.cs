using System;

//This is a class, it's essentially a defined program
class Fraction
{

    //These are attributes. Variables
    private int _top;
    private int _bottom;
    private int wholeNumber;

    //This is a constructor. It is a process or equation type of operation that utilizes the attributes
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Inside the paranthesis are parameters, variables in the class that are passed to the constructor
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //This is a getter. I still dont knwo what it's supposed to do
    public string GetFractionString()
    {
        string answer = $"{_top}/{_bottom}";
        return answer;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}