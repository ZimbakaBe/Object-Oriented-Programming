using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        //public string name;
        //public string breed;

        public Dog()
        {
            
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuu!", this.Name ?? "[unnamed dog]",this.Breed ?? "[unknonw breed]");
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) said: Bauuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknonw breed]");
        }
    }
}
