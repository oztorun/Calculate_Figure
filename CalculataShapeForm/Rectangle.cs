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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void btnRectangle_calculate_Click(object sender, EventArgs e)
        {
            // inputları al

            // hesap et
            // sonucu yaz
            double xAxis = Convert.ToDouble(txtRectangle_a.Text);
            double yAxis = Convert.ToDouble(txtRectangle_b.Text);

             Shape s1=ShapeFactory.Instance().CreateShape(CalculateShape.Figure.Rectangle,xAxis,yAxis);
             double perimeter = s1.getPerimeter();
             double area = s1.getArea();

            txtRectangle_perimeter.Text = perimeter.ToString();
             txtRectangle_area.Text = area.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllRectangleBox();
        }

        private void clearAllRectangleBox()
        {
            txtRectangle_a.Clear();
            txtRectangle_b.Clear();
            txtRectangle_perimeter.Clear();
            txtRectangle_area.Clear();
            txtRectangle_a.Select();
        }
    
    }
}
