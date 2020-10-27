using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T> where T : IComparable
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public int GetGreaterElement(T value)
        {
            int counter = 0;
            foreach (T item in Values)
            {
                if (item.CompareTo(value)>0)
                {
                    counter++;
                }

            }
            return counter;
        }
    }
}
