using System;

public class Fraction
{
    private int _top;
    private int _down;

    public Fraction()
    {
        _top = 1;
        _down = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _down = 1;
    }

    public Fraction(int top, int down)
    {
        _top = top;
        _down = down;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_down}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _down;
    }
}