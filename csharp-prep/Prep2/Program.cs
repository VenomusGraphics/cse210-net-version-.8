using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("is the grade a percentage? Yes or no (y/n)? ");
        string userinput = Console.ReadLine();

        if (userinput == "y" )
        {
                Console.Write("what is the percent? ");
                string  percent = Console.ReadLine();
                int x = int.Parse(percent);

                string letter = "A";

                if (x > 89 )
                {
                    letter = "A";
                }
                else if (x > 79)
                {
                    letter = "B";
                }
                else if (x > 69)
                {
                    letter = "C";
                }
                else if (x > 59)
                {
                    letter = "D";
                }
                else if (x < 60)
                {
                    letter = "F";
                }
                else if (x >101 )
                {
                    Console.Write("there my be an error please try again");
                }
                else
                {
                    Console.Write("invalad input");
                }

                Console.Write($"your grade is |{letter}|");

                if (x > 69)
                {
                    Console.Write("passing grade!");
                }
                else
                {
                    Console.Write("Grade is not passing tutor sujested.");
                }
        }

    }
}