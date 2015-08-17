using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{   [Version(0,1)]
    public class GenericList<T> : IEnumerable where T : IComparable<T>
    {
        private const int defaultCapacity = 16;

        private T[] elements;

        private int count;

        public GenericList(int capacity = defaultCapacity)
        {
            this.count = 0;
            this.elements = new T[capacity];
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (this.count == 0)
                {
                    throw new ArgumentException("List cannot be empty.");
                }
                if (index < 0 || index > this.count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range.");
                }
                return this.elements[index];
            }
            set { this.elements[index] = value; }
        }

        public void Add(T element)
        {
            if (this.count == this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public int AccessingElement(T element)
        {
            if (this.count == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }

            for (int i = 0; i < this.elements.Length; i++)
            {
                T checkElement = this.elements[i];
                if (checkElement.Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveElement(int index)
        {
            if (this.count == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }
            if (index < 0 || index > this.count)
            {
                throw new ArgumentException("Invalid index");
            }

            for (int i = index; i < this.count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            this.count--;
        }

        public void InsertElement(T element, int index)
        {
            if (this.count == 0)
            {
                throw new ArgumentException("List is empty.");
            }
            if (index < 0 || index > this.count)
            {
                throw new ArgumentException("Invalid index.");
            }
            if (this.count == this.elements.Length)
            {
                this.Resize();
            }

            for (int i = this.count; i >= index - 1; i--)
            {
                elements[i] = elements[i - 1];
            }

            this.elements[index] = element;
            count++;
        }

        public void Clear()
        {
            Array.Clear(elements, 0, this.elements.Length);
            this.count = 0;
        }

        public int FindingElementIndexByValue(T element)
        {
            if (this.count == 0)
            {
                throw new ArgumentException("List is empty.");
            }
            int index = Array.IndexOf(elements, element);
            return index;
        }

        public bool Cointains(T element)
        {
            if (this.count == 0)
            {
                throw new ArgumentException("List is empty.");
            }

            for (int i = 0; i < this.elements.Length; i++)
            {
                T currentElement = elements[i];
                if (currentElement.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new ArgumentException("List is empty.");
            }

            T min = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                T currentElement = elements[i];
                if (currentElement.CompareTo(min) < 0)
                {
                    min = currentElement;
                }
            }
            return min;
        }

        public T Max()
        {
            T max = elements[0];

            for (int i = 0; i < this.count; i++)
            {
                T currentElement = elements[i];
                if (currentElement.CompareTo(max) > 0)
                {
                    max = currentElement;
                }
            }
            return max;
        }

        public override string ToString()
        {
            var resultElements = this.elements.Take(this.count);
            return string.Join(", ", elements);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.Take(this.count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Version()
        {
            Type type = typeof(GenericList<T>);
            object[] attr = type.GetCustomAttributes(false);
            foreach (Attribute atr in attr)
            {
                if (atr is Version)
                {
                    Version a = (Version)atr;

                    Console.WriteLine("{0}.{1}", a.Major, a.Minor);
                }
            }
        }

        public void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = elements[i];
            }

            this.elements = newElements;
        }
    }
}
