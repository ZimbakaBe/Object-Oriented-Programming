using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double radius, double height)
            : base(radius, height)
        {
        }

        public override double CalculateArea()
        {
            double area = this.Radius * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Height*2 + this.Radius*2;
            return perimeter;
        }
    }
}
