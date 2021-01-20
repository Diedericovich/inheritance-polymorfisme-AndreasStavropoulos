using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilinder
{
    class Circle : Point
    {

        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle () 
        {

        }
        public Circle(double x, double y, double r) : base (x, y)
        {
            R = r;
        }

        public double Circumference () 
        {
            return 2 * Math.PI * R;
        }

        public virtual double Surface() 
        {
            return Math.PI * Math.Pow(R,2);
        }

        public override string Data()
        {
            string radius = $" Radius {R}";
            return base.Data() + radius;            
        }
    }
}
