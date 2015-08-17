using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Point3D
{
    public class Point3D
    {
        private static readonly Point3D startingpoint = new Point3D(0,0,0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartingPoint
        {
            get { return startingpoint; }
        }

        public override string ToString()
        {
            return string.Format("Point coordinates: \n{0}\n{1}\n{2}", this.X, this.Y,this.Z);
        }
    }
}
