using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateShape
{
    internal class Rectangle:Shape
    {
        internal double a, b;

        internal Rectangle(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        public override double getPerimeter()
        {
            return (a + b) * 2;
        }

        public override double getArea()
        {
            return a * b;
        }
    }
}
