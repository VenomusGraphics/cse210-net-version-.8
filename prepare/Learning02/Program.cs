using System;

class Program
{
    public string _JobTitle ;
    public string _companey;
    public int _startyear;
    public int _endyear;

    public void Display()
    {
        Console.Write($"{_JobTitle}|{_companey}|{-_startyear}-{_endyear}");
    }
}