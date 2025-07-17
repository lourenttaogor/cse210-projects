using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction();
        frac.SetTop(1);
        Fraction frac2 = new Fraction();
        frac2.SetTop(6);
        Fraction frac3 = new Fraction();
        frac3.SetTop(3);
        frac3.SetBottom(4);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetTop());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetTop());
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac3.GetFractionString());  
        Console.WriteLine(frac3.GetDecimalValue());  
       

    }
}