using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Point3D;

namespace _2.DistanceCalculator
{
    class Distance
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2,3,4);
            Point3D p2 = new Point3D(4,-1,2);

            Console.WriteLine(DistanceCalculator.CalculateDistance(p1, p2));         
        }
    }
}
