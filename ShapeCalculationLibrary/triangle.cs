using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShapeCalculationLibrary;

namespace CalculateShape
{
   internal class Triangle:Shape
    {
        double a, b, c;

        internal Triangle(double _a, double _b, double _c)
        {
            a = _a;
            b = _b;
            c = _c;
        }

        public override double getPerimeter()
        {
            if (!checkTriangleEdges())
                throw new TriangleUnsupportedEdgesException("Gönderilen değerlerle bir üçgen çizilemez.");
            return a + b + c;
        }
       
        public override double getArea()
        {
            if (!checkTriangleEdges())
                throw new TriangleUnsupportedEdgesException("Gönderilen değerlerle bir üçgen çizilemez.");
     
                double u = (a + b + c) / 2.0;
                double result = Math.Sqrt((u * (u - a) * (u - b) * (u - c)));
                return result;
        }

        private bool checkTriangleEdges()
        {
            if (a + b < c) return false;
            if (c + b < a) return false;
            if (a + c < b) return false;

            return true;
        }

       
        
    }
}
