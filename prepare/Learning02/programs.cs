using System;
class Program
{
    // not going to lie i definly didnt unerstand how to get to the get my jobnum1 workin so i looked at the sample
    static void Main(string[] args)
    {
        Console.WriteLine("Hello user!");

        JobsTitle JobNum1 = new JobsTitle();
        
        JobNum1._JobTitle = "engeriner";
        JobNum1._companey ="Microsoft";
        JobNum1._startyear= 2019;
        JobNum1._endyear  =2023;

        
        JobsTitle JobNum2 = new JobsTitle();

        JobNum2._JobTitle = "Developer";
        JobNum2._companey ="Google";
        JobNum2._startyear= 2022;
        JobNum2._endyear  =2023;

        Resume Resumes = new Resume();
        Resumes. _name ="David Row";

        Resumes._Job.Add(JobNum1);
        Resumes._Job.Add(JobNum2);

        Resumes.Display();



    }

    


}