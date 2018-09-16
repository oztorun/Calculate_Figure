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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void btnCircle_calculate_Click(object sender, EventArgs e)
        {
           
            double radius = Convert.ToDouble(txtCircle_a.Text);

            Shape s1 = ShapeFactory.Instance().CreateShape(CalculateShape.Figure.Circle, radius);
            double perimeter = s1.getPerimeter();
            double area = s1.getArea();

            MessageBox.Show(string.Format("Perimeter: {0}",perimeter));

            txtCircle_perimeter.Text = perimeter.ToString();
            txtCircle_area.Text = area.ToString();

           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearAllCircleBox();
        }

        private void clearAllCircleBox()
        {
            txtCircle_a.Clear();
            txtCircle_perimeter.Clear();
            txtCircle_area.Clear();
            txtCircle_a.Select();
        }

        private void Circle_Load(object sender, EventArgs e)
        {

        }
    }
}
