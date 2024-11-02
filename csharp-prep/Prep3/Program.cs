using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write ("would you like ot play a number game? " );

        string Responce = Console.ReadLine();

        if (Responce == "yes")
        {
            
          
        
            Random RandomGenerator = new Random();
            int Rando = RandomGenerator.Next(1,101);
            // when i tested it gave really big numbers so i looked at the solution
            //hopefully this works Rip if it doesnt the numbers it gave were too big at first
            
            int UserNum = -1;
            while (UserNum != Rando)
                {
                    Console.Write("guess my number!");

                    // i looked up what the best way to do this was.
                    UserNum = int.Parse(Console.ReadLine());

                    if (Rando > UserNum)
                    {
                        Console.Write("too low");
                    }
                    else if (Rando < UserNum)
                    {
                        Console.Write("to big");
                    }
                    else
                    {
                        Console.Write("there it is! you win");
                    }
            
                }
        

        }

    }
}