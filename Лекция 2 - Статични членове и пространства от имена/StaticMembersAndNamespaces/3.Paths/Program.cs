using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Point3D;

namespace _3.Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point3D point1 = new Point3D(1, 2, 3);
                Point3D point2 = new Point3D(-3, 4, 0);
                Path3D path = new Path3D(point1, point2);

                Storage.SavePathToFile("../../path.txt", path.ToString());
                Console.WriteLine("Load from file:\n" + Storage.LoadPathFromFile("../../path.txt"));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
