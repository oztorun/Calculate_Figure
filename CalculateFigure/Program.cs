using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShapeCalculationLibrary;

namespace CalculateShape
{
    class Program
    {
        static void Main(string[] args)
        {
          
                ShapeFactory.Instance().CreateShape(Figure.Rectangle, 10, 20);
                ShapeFactory.Instance().CreateShape(Figure.Square, 10);
                ShapeFactory.Instance().CreateShape(Figure.Circle, 5);
                Shape s1 = ShapeFactory.Instance().CreateShape(Figure.Square, 10);
                Shape s2 = ShapeFactory.Instance().CreateShape(Figure.Triangle, 10, 3, 2);
                Shape s3 = ShapeFactory.Instance().CreateShape(Figure.Circle, 5);
                Shape s4 = ShapeFactory.Instance().CreateShape(Figure.Rectangle, 10, 20);



                Console.WriteLine(s2.getArea());


            Console.ReadKey();
        }
    }
}
