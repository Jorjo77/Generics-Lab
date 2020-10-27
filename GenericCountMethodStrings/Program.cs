using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> values = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                values.Add(input);
            }
            Box<double> box = new Box<double>(values);
            double compareValue = double.Parse(Console.ReadLine());

            double largerElementsCount = box.GetGreaterElement(compareValue);
            Console.WriteLine(largerElementsCount);
        }
    }
}
