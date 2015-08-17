using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Triangle : BasicShape
    {
        private double cSide;

        public Triangle(double aSide, double bSide, double cSide)
            : base(aSide,bSide)
        {
            this.CSide = cSide;
        }

        public double CSide
        {
            get { return this.cSide; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("All sides of the triangle should have positive values.");
                }
                this.cSide = value;
            }
        }

        public override double CalculateArea()
        {
            double s = (this.Height + this.Radius + this.CSide)/2;
            double area = Math.Sqrt(s*(s - this.Height)*(s - this.Radius)*(s - this.CSide));

            if (double.IsNaN(area))
            {
                throw new ArgumentException("Not a triangle if one of the sides is bigger than the other two combined.");
            }
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Height + this.Radius + this.CSide;
            return perimeter;
        }
    }
}
