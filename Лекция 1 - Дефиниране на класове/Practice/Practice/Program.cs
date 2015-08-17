using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //class Rectangle
    //{
    //    public const int FieldSize = 1024;

    //    public readonly int width;
    //    public readonly int height;

    //    public Rectangle(int size): this(size,size)
    //    {
    //        //this.width = size;
    //        //this.height = size;
    //    }

    //    public Rectangle(int width = 0, int height = 0)
    //    {
    //        this.width = width;
    //        this.height = height;
    //    }

    //    public int Width
    //    {
    //        get { return this.width; }
    //    }

    //    public int Height
    //    {
    //        get { return this.height; }
    //    }

        
    //    public override string ToString()
    //    {
    //        return string.Format("({0},{1})", this.Width, this.Height);
    //    }

    //    public int Area
    //    {
    //        get { return this.Width*this.Height; }
    //    }
    //}

    public class Program
    {
        static void Main(string[] args)
        {
            var polygon = new Point[]
            {
                new Point(55,-4),
                new Point(7, 2),
                new Point(4,4),
                new Point(55, -4), 
            };

            var area = CalcPolygonArea(polygon);
            Console.WriteLine(area);
        }

        private static double CalcPolygonArea(Point[] points)
        {
           var area = Math.Abs(points.Take(points.Length - 1)
                .Select((p, i) => (points[i + 1].X - p.X)*(points[i + 1].Y + p.Y))
                .Sum()/2.0);
            return area;
        }
    }
}
