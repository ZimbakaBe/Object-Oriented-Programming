using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _2.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private int hdd;
        private string screen;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.Battery = battery;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be null or empty");
                }
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Processer cannot be null or empty");
                }
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ram cannot be null or empty");
                }
            }
        }

        public string GraphicCard
        {
            get { return this.graphicCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Graphic card cannot be null or empty");
                }
            }
        }

        public int HDD
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HDD card cannot be null or empty");
                }
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Screen card cannot be null or empty");
                }
            }
        }

        public Battery Battery { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop description:");
            result.AppendLine("Model: " + this.model);

            if (manufacturer != null)
            {
                result.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (processor != null)
            {
                result.AppendLine("Processor: " + this.Processor);
            }
            if (ram > 0)
            {
                result.AppendLine("Ram: " + this.Ram + "GB");
            }
            if (graphicCard != null)
            {
                result.AppendLine("Graphics card: " + this.GraphicCard);
            }
            if (hdd > 0)
            {
                result.AppendLine("HDD: " + this.HDD + "GB");
            }
            if (screen != null)
            {
                result.AppendLine("Screen: " + this.Screen);
            }
            if (Battery.BatteryType != null)
            {
                result.AppendLine("Battery type: " + this.Battery.BatteryType);
            }
            if (Battery.BatteryLife > 0)
            {
                result.AppendLine("Battery life: " + this.Battery.BatteryLife + "hours");
            }

            result.AppendLine("Price: " + this.Price + "lv.");
            return result.ToString();
        }
    }
}
