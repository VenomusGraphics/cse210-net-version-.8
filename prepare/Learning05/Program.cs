using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
    
        List<ShapesAndColor> shapes = new List<ShapesAndColor>();

        Square s1 = new Square("yellow",3);
        shapes.Add(s1);

        Rectangle s2 =new Rectangle("purple",6,10);
        shapes.Add(s2);

        Circle s3 =new Circle("blue",6);
        shapes.Add(s3);
        
    foreach (ShapesAndColor s in shapes)
    {
        string color = s.Getcolor();

        double _Area = s.Getarea();

        Console.WriteLine($"The{color} shape with area of {_Area}.");
    }
    }
}