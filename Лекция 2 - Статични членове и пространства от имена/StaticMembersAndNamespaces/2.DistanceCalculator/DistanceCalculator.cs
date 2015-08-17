using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using _1.Point3D;

namespace _2.DistanceCalculator
{
    static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            return
                Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2) +
                          Math.Pow(point2.Z - point1.Z,2));
        }
    }
}
