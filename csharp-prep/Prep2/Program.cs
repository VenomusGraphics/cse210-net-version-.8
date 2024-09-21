using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is the grade persent? ");
        string grade= Console.ReadLine();
        int number =int.Parse(grade);

        if (number <= 100 & number > 90)
        {Console.WriteLine("A"); return; }
        if (number >= 80 & number < 90)
        {Console.WriteLine("B");}
        if (number >= 70 & number < 80)
        {Console.WriteLine("c");}
        if (number >= 60 & number < 70)
        {Console.WriteLine("d");}
        if(number <= 60 & number > 0)
        {Console.WriteLine("f");}
        else if (number > 100 & number < 0)
        {Console.WriteLine("imposable value");}
        
    }
}