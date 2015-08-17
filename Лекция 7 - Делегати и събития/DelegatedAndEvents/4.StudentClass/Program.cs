using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _4.StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Petar", 22);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyChanged, eventArgs.OldValue, eventArgs.NewValue);
            };

            student.Name = "Mariya";
            student.Age = 19;
        }
    }
}
