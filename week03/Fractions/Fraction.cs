using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top} / {_bottom}");
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
        Console.WriteLine($"{_top} / {_bottom}");
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        Console.WriteLine($"{_top} / {_bottom}");
    }

    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
        return _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottom)
    {
        return _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top} / {_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double) _top / _bottom;
    }
}