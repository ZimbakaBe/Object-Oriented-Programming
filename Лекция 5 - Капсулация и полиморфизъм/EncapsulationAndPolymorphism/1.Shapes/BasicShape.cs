using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double radius;
        private double height;

        public BasicShape(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public double Radius 
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative.");
                }
                this.radius = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative.");
                }
                this.height = value;
            }
        } 

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
