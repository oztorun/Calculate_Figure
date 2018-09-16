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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
            txtTriangle_a.Select();
        }

       

        private void btnTriange_calculate_Click(object sender, EventArgs e)
        {
           
            double edgeA = Convert.ToDouble(txtTriangle_a.Text);
            double edgeB = Convert.ToDouble(txtTriangle_b.Text);
            double edgeC = Convert.ToDouble(txtTriangle_c.Text);

          
            Shape s1=ShapeFactory.Instance().CreateShape(CalculateShape.Figure.Triangle, edgeA, edgeB, edgeC);
            double perimeter = s1.getPerimeter();
            double area = s1.getArea();

         
            txtTriangle_perimeter.Text = perimeter.ToString();
            txtTriangle_area.Text = area.ToString();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearTriangleTextBox();
        }

        private void clearTriangleTextBox()
        {
            txtTriangle_a.Clear();
            txtTriangle_b.Clear();
            txtTriangle_c.Clear();
            txtTriangle_perimeter.Clear();
            txtTriangle_area.Clear();
            txtTriangle_a.Select();
        }

        
    }
}
