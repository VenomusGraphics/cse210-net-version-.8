using System;

    public class Circle : ShapesAndColor
    {
        public double _radius;
        public Circle(string color, double radius) : base (color)
        {
            _radius = radius;
        }
        public override double Getarea()
        {
            return _radius*_radius*Math.PI;
        }
    }