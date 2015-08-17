using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int start = 1;
            string n = Console.ReadLine();
            while (counter <= 10)
            {
                try
                {
                    int number = int.Parse(n);
                    ReadNumber(start, number);
                    counter++;
                    start = number;
                }
                catch (ArgumentOutOfRangeException outRange)
                {
                    Console.Error.WriteLine("Input number not in the range [{0}..100] {1}", start, outRange.ParamName);
                }
                catch (FormatException frmExc)
                {
                    Console.Error.WriteLine("{0}", frmExc.Message);
                }
                finally
                {
                    Console.WriteLine("Enter new number in  range [{0}..100]:", start);
                    n = Console.ReadLine();
                }
            }
        }

        static void ReadNumber(int start, int n)
        {
            if (n <= start || n >= 100)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
