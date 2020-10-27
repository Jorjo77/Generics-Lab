using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public List<T> Values { get; set; } = new List<T>();

        public Box(List<T> values)
        {
            this.Values = values;
        }

        public void SwapElements(int firstElement, int secondElement)
        {
            T temp = Values[firstElement];
            Values[firstElement] = Values[secondElement];
            Values[secondElement] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }
            return sb.ToString();
        }
    }
}
