using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InterestCalculatorDelegate
{
    class Program
    {
        private const int n = 12;

        static void Main()
        {
            InterestCalculator.GetInteres g1 = GetSimpleInterest;
            InterestCalculator.GetInteres g2 = GetCompoundInterest;

            var a = new InterestCalculator(2500m, 7.2m, 15, Types.Simple);
            var b = new InterestCalculator(500m, 5.6m, 10, Types.Compound);

            Console.WriteLine(a);
            Console.WriteLine(g1(2500m, 7.2m, 15));
            Console.WriteLine(b);
            Console.WriteLine(g2(500m, 5.6m, 10));
        }

        static decimal GetSimpleInterest(decimal sum, decimal interests, int years)
        {
            return sum * (1 + (interests / 100 * years));
        }

        static decimal GetCompoundInterest(decimal sum, decimal interests, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interests / 100 / n)), years * n);
        }
    }
}
