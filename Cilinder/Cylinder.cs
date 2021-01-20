using System;

namespace Cilinder
{
    internal class Cylinder : Circle
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set { _h = value; }
        }

        public Cylinder()
        {
        }

        public Cylinder(double x, double y, double r, double h) : base(x, y, r)
        {
            H = h;
        }

        public double Volume()
        {
            double surface = base.Surface();
            return Math.Round(surface * H, 2);
        }

        public override double Surface()
        {
            double surface = base.Surface();
            double circumference = Circumference();
            return Math.Round((2 * surface) + (circumference * H), 2);
        }

        public override string Data()
        {
            string addInfo = $" Height = {H}" +
                $"\n Surface = {Surface()}" +
                $"\n Volume = {Volume()}";
            return base.Data() + addInfo;
        }
    }
}