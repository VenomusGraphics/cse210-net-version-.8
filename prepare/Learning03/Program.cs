using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello write a number");

        Fraction frac1= new Fraction();
        Console.WriteLine(frac1.Getfration(1,1));
        Console.WriteLine(frac1.GetValue());

        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.Getfration(int.Parse(Console.ReadLine()),1));
        Console.WriteLine(frac2.GetValue());

        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.Getfration(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
        Console.WriteLine(frac3.GetValue());

        Fraction frac4= new Fraction(1, 3);
        Console.WriteLine(frac4.Getfration(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
        Console.WriteLine(frac4.GetValue());

        
    }
}