using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        FractionHolder top = new FractionHolder();
        Console.WriteLine(top.GetFractionString());
        Console.WriteLine(top.GetBottom());
        Console.WriteLine(top.GetTop());
        FractionHolder top2 = new FractionHolder(6);
        Console.WriteLine(top2.GetFractionString());
        Console.WriteLine(top2.GetBottom());
        Console.WriteLine(top2.GetTop());
        FractionHolder topBottom = new FractionHolder(5, 6);
        Console.WriteLine(top2.GetTop());
        Console.WriteLine(topBottom.GetFractionString());
        Console.WriteLine(top.GetDecimalValue());
        top.SetTop(10);
        top.SetBottom(5);
        Console.WriteLine(top.GetDecimalValue());
        Console.WriteLine(top.GetFractionString());
    }
}