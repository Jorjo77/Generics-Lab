using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i< n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                values.Add(input);
            }

            Box<int> box = new Box<int>(values);

            int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse).ToArray();

            int firstElement = arr[0];
            int secondElement = arr[1];
            box.SwapElements(firstElement, secondElement);
            Console.WriteLine(box);
        }
    }
}
