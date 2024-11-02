using System;


    public abstract class ShapesAndColor
    {
        private string _color;
        protected string _Area;

    public ShapesAndColor(string color)
    {
        _color =color;
    }
    public string Getcolor()
    {
        return _color;
    }

    public void Setcolor(string color)
    {
        _color = color;
    }
    public abstract double Getarea();
  
    }