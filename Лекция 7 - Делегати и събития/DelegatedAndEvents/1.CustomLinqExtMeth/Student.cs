using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CustomLinqExtMeth
{
    class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (grade < 0)
                {
                    throw new ArgumentNullException("Grade cannot be negative.");
                }
                this.grade = value;
            }
        }
    }
}
