using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();

            try
            {
                int number = int.Parse(num);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double sqrt = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} is: {1}", number, sqrt);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid input.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            finally
            {
                Console.WriteLine("Good buy.");
            }
        }
    }
}
