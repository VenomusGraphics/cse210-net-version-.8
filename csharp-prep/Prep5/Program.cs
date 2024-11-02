using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        WelcomMessage();
        string name = UserName();
        int numb = GrabNumber();
        int squr = SquardNumber(numb);
        EntInfo(squr,name);


        static void WelcomMessage()
        {
            Console.WriteLine("Welcom to Jurasic Park");
        }
        static string UserName()
        {
            Console.Write("Enter your name");
            string name = Console.ReadLine();
            return name;
        }
        static int GrabNumber()
        {
    
            Console.Write("Enter your name");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquardNumber(int numb)
        {
        int squared = numb * numb;
        return squared;
        }
        static void EntInfo(int squr,string name)
        {
            Console.WriteLine($"{name}, you number squared is: |{squr}|");
        }
    
    
    }
}