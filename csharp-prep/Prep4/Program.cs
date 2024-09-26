using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("number list");
        Console.Write("enter a list of numbers, when you are satisfied type 0 ");
        int nugh = -1;
        List<int> number = new List<int>();
        while (nugh != 0)
        nugh =int.Parse(Console.ReadLine());
        if (nugh != 0)
        {
            number.Add (nugh);
        }
        int sum = 0;
        foreach (int n in number)
        {
            sum += n;
        }
        Console.WriteLine($"the sum is:{sum}");
        float avrage =(float)sum / (float)number.Count;
        Console.WriteLine($"the avrage is:{avrage}");

        int max=number[0];
        foreach (int n in number)
        {
            if (n > max)
            {
                max = n;
            }
        Console.WriteLine($"the max is:{max}");
        }
        
        
        
    }
}