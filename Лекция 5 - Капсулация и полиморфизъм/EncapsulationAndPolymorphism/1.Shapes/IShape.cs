using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public interface IShape
    {
        double Radius { get; set; }

        double CalculateArea();
        double CalculatePerimeter();
    }
}
