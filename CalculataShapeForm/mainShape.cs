using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculator.Model.Factory;

namespace CalculataShapeForm
{
    public partial class mainShape : Form
    {
        public mainShape()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
           
                 var  Rectangle = new Rectangle();
                 Rectangle.Show();
}

        private void btnSquare_Click(object sender, EventArgs e)
        {
            var Square = new Square();
            Square.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var Circle = new Circle();
            Circle.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var Triangle = new Triangle();
            Triangle.Show();
            
            
        }

        private void lblShape_Click(object sender, EventArgs e)
        {
         
        }


        }
    }

