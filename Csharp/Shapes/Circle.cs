using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle:IShape
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public double GetArea()
        {
            return Math.Round(3.14*Math.Pow(Radius,2),2);
        }
        public double GetPerimeter()
        {
            return Math.Round(2*3.14*Radius,2);
        }
    }
}
