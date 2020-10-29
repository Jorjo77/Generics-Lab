using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine()
                .Split();
            string personName = firstInput[0] + " " + firstInput[1];
            string adress = firstInput[2];
            Tuple<string, string> personInfo = new Tuple<string, string>(personName, adress);

            string[] secondInput = Console.ReadLine()
                .Split();

            string name = secondInput[0];
            int beerLiters = int.Parse(secondInput[1]);
            Tuple<string, int> personBeerInfo = new Tuple<string, int>(name, beerLiters);

            string[] thirdInput = Console.ReadLine()
                .Split();
            int fitstNumber = int.Parse(thirdInput[0]);
            double secondNumber = double.Parse(thirdInput[1]);

            Tuple<int, double> numbersInfo = new Tuple<int, double>(fitstNumber, secondNumber);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeerInfo);
            Console.WriteLine(numbersInfo);

        }
    }
}
