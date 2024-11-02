using System;

    public class Square : ShapesAndColor
    {
        private double _side;
        
        public Square(string color, double side) : base (color)
        {
            _side = side;
        }
        public override double Getarea()
        {
            return _side * _side;
        }
    }