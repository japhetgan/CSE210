using System;
using System.Dynamic;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,4);
        Fraction fraction4 = new Fraction(1,3);


        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimal());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimal());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimal());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimal());
    }

}