using System;
using System.Windows.Forms;

namespace Cilinder
{
    public partial class Cilinder : Form
    {
        private Point point;
        private Circle circle;
        private Cylinder cylinder;
        public Random random = new Random();
        private bool buttonPoint = false;
        private bool buttonCircle = false;
        private bool buttonCylinder = false;

        public Cilinder()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double randomX = random.Next(1, 10);
            double randomY = random.Next(1, 10);
            point = new Point(randomX, randomY);
            Message(buttonPoint, "point", point);
            buttonPoint = true;
            btn2.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double randomR = random.Next(1, 10);
            circle = new Circle(point.X, point.Y, randomR);
            Message(buttonCircle, "circle", circle);
            buttonCircle = true;
            btn3.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double randomH = random.Next(1, 10);
            cylinder = new Cylinder(point.X, point.Y, circle.R, randomH);
            Message(buttonCylinder, "cylinder", cylinder);
            buttonCylinder = true;
        }

        public void Message(bool btn, string field, Point obj)
        {
            if (btn == false)
            {
                MessageBox.Show(obj.Data(), $"Coordinates of the {field}");
            }
            else
            {
                MessageBox.Show(obj.Data(), $"Coordinates of the {field} after editing");
            }
        }
    }
}