using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Rectangle:IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length,double width)
        {
            Length=length;
            Width=width;
        }
        public double GetArea()
        {
            return Length * Width;
        }
        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
