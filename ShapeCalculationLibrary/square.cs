using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShapeCalculationLibrary;

namespace CalculateShape
{
    internal class Square:Shape
    {
        double a;

        internal Square(double _a)
        {
            a = _a;
        }

        public override double getPerimeter()
        {
            return 4 * a;
        }

        public override double getArea()
        {
            return a * a;
        }

    }
}
