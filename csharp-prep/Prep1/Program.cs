using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("what is your first name? ");
       string NameFirst = Console.ReadLine ();

       Console.Write("what is your last name? ");
       string NameLast = Console.ReadLine ();

       Console.WriteLine($"your name is {NameLast},{NameFirst} {NameLast}");
    }
}