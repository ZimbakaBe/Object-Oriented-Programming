using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = int.Parse(Console.ReadLine());

            long secondNumber = int.Parse(Console.ReadLine());

            string stringToReplacedWith = Console.ReadLine();

            Console.WriteLine(ReplaceNumberWithString(GetSum(firstNumber, secondNumber), stringToReplacedWith));
        }

        public static long GetSum(long firstNumber, long secondNumber)
        {
            long sum = 0;

            for (long currentNumber = firstNumber; currentNumber < secondNumber; currentNumber++)
            {
                var checkDivider = currentNumber % 5;

                if (checkDivider != 0)
                {
                    sum += checkDivider;
                }

                else
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }

        public static string ReplaceNumberWithString(long sum, string stringToReplaceWith)
        {
            string sumToString = sum.ToString();

            string result = String.Empty;

            if (sum % 2 != 0)
            {
                string stringToBeReplaced = sumToString[sumToString.Length - 1].ToString();

                result = sumToString.Replace(stringToBeReplaced, stringToReplaceWith);

            }
            if (sum % 2 == 0)
            {
                string stringToBeReplaced = sumToString[0].ToString();
                result = sumToString.Replace(stringToBeReplaced, stringToReplaceWith);
            }
            return result;
        }
    }
}
