using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTime a = new AsyncTime(PrintLetterOnConsole, 5, 500);
            a.Execute();
            AsyncTime b = new AsyncTime(PrintNumberOnConsole, 3, 1000);
            b.Execute();
        }
        private static void PrintLetterOnConsole(int i)
        {
            char letter = (char)('a' + i);
            Console.WriteLine(letter);
        }

        private static void PrintNumberOnConsole(int i)
        {
            Console.WriteLine(i + 1);
        }
    }
}
