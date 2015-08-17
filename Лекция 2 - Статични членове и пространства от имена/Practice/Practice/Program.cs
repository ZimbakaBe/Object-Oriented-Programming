using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray32 bits = new BitArray32(54);
            bits.SetBitAt(1, 0);
            Console.WriteLine(bits.GetBit(0));
        }
    }
}
