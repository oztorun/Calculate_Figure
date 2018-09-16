using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CalculateShape;
using ShapeCalculationLibrary;

namespace CalculataShapeForm
{
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
            
        }

        private void btnSqure_calculate_Click(object sender, EventArgs e)
        {
           
            double xyAxis = Convert.ToDouble(txtSquare_a.Text);
            
           
            Shape s1 = ShapeFactory.Instance().CreateShape(CalculateShape.Figure.Square, xyAxis);
            double perimeter=s1.getPerimeter();
            double area=s1.getArea();

            
            txtSquare_perimeter.Text=perimeter.ToString();
            txtSquare_area.Text=area.ToString();
 

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllSquareBox();
        }

        private void clearAllSquareBox()
        {
            txtSquare_a.Clear();
            txtSquare_perimeter.Clear();
            txtSquare_area.Clear();
            txtSquare_a.Select();
        }

        private void txtSquare_a_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
