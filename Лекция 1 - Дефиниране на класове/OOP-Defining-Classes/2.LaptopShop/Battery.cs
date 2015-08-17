using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LaptopShop
{
    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryModel, double batteryLife)
        {
            this.BatteryType = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery type cannot be empty or null");
                }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life cannot be empty or null");
                }
                this.batteryLife = value;
            }
        }
    }
}
