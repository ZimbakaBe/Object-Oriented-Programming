using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.StudentClass
{
    public delegate void PropertyChangedEventArgsHandler(Student student, PropertyChangedEventArgs args);

    public class Student
    {
        public event PropertyChangedEventArgsHandler PropertyChanged;
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name", this.Name, value));
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age", this.Age, value));
                }
                this.age = value;
            }
        }
    }
}
