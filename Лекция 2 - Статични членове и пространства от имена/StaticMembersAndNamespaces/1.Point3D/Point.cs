using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Point3D
{
    class Point
    {
        static void Main(string[] args)
        {
            Point3D p = new Point3D(2,3,6);
            Console.WriteLine(p);

            Point3D p2 = new Point3D(-1,2.3,24);
            Console.WriteLine(p2);

            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
