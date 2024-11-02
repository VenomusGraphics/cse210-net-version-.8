using System;
// I orginaly put this guy below in the wrong spot now he lives here after the i look at the sample
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
    
    int user = -1;
    List<int> numbers = new List<int>();
     while (user != 0 )
     {
        Console.Write("add a nmber to the list. |(0 to end)| ");
        user = int.Parse(Console.ReadLine());
        if (user != 0)
        {
            numbers.Add(user);
        }

        // had to look up this here so i could get an idea
        // and used some thins i rembemer from python bu converted to c#
        int SumUp = -1;
        foreach (int number in numbers)
        {
            SumUp += number;
        }
        Console.Write($"Sum of list is:|{SumUp} |");
        
        float ave = ((float)SumUp)/ numbers.Count;
        Console.Write($"Your average is:|{ave}|");

        int Maximum = numbers[0];
        // reused the peviously learned thing here
        foreach (int number in numbers)
        {
            if (number > Maximum)
            {
                Maximum = number;
            }
        }
        Console.Write($"the max is:|{Maximum}|");

        


     }



    }
}