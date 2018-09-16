using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateShape
{
   internal class Circle:Shape
    {
        double a;

        internal Circle(double _a)
        {
            a = _a;
        }

        public override double getPerimeter()
        { 
            return 2*3.14*a;
        }

        public override double getArea()
        {
            return 3.14 * a * a;
        }
    }
}
