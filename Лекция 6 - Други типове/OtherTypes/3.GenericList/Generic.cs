using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    class Program
    {   
        static void Main(string[] args)
        {
            var list = new GenericList<int> {2, 6, 3, 4, 1, 23, 12, 73, 17, 93, 823, 123, 64, 32 ,12, 63};
            list.Version();
            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.AccessingElement(3));
            Console.WriteLine(list);
            list.RemoveElement(4);
            Console.WriteLine(list);
            list.InsertElement(5,9);
            Console.WriteLine(list);
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list);
        }
    }
}
