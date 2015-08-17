using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InterestCalculator
{
    class Program
    {
        private const int n = 12;

        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> simple = GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compound = GetCompoundInterest;

            var a = new InterestCalculator(500m,5.6m,10,compound);
            var b = new InterestCalculator(2500m,7.2m,15,simple);

            Console.WriteLine(a);
            Console.WriteLine(b);

        }

        static decimal GetSimpleInterest(decimal sum, decimal interests, int years)
        {
            return sum*(1 + (interests / 100 * years));
        }

        static decimal GetCompoundInterest(decimal sum, decimal interests, int years)
        {
            return sum*(decimal)Math.Pow((double)(1 + (interests/100/n)), years*n);
        }
    }
}
