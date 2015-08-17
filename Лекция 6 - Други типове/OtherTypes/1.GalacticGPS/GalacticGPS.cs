using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GalacticGPS
{
    class GalacticGps
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);

            //Argument out of range exception
            Location notHome = new Location(-100.215123, 150.32100, Planet.Mercury);
            Console.WriteLine(notHome);
        }
    }
}
