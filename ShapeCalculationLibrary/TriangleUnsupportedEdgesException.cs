using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeCalculationLibrary
{
    public class TriangleUnsupportedEdgesException : Exception
    {

        public TriangleUnsupportedEdgesException(string exceptionMessge) : base(exceptionMessge)
        {
          
        }
    }
}
