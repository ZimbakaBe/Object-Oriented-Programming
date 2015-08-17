using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GalacticGPS
{
    struct Location
    {
        private double latitude;
        private double longtitude;

        private Planet Planet { get; set; }

        public Location(double latitude, double longtitude, Planet planet) : this()
        {
            this.Planet = planet;
            this.Latitude = latitude;
            this.Longtitude = longtitude;
        }

        public double Latitude 
        {
            get { return this.latitude; }
            set
            {
                if (value > 90 | value < -90)
                {
                    throw new ArgumentException("Latitude should be in the range -90 to 90.");
                }
                this.latitude = value;
            }
        }

        public double Longtitude
        {
            get { return this.longtitude; }
            set
            {
                if (value > 180 | value < -180)
                {
                    throw new ArgumentException("Longtitude should be in the range -180 to 180.");
                }
                this.longtitude = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
        }
    }
}
