using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to number game");
        Random RandomGenNumb =new Random();
        int number = RandomGenNumb.Next(1,101);
        int guess = -1;
        while (guess != number)
        {
            Console.Write("what is the magic?");
          guess= int.Parse(Console.ReadLine());

           if (guess < number)
           {
            Console.WriteLine("higher; guess again");
           }
           else if (guess > number)
           {
            Console.WriteLine("lower; guess again");
           }
           else 
           {
            Console.WriteLine("you guessed the number");
           }

            
            
    
        }



    }
}