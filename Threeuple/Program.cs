using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine()
                .Split();
            string personName = firstInput[0] + " " + firstInput[1];
            string addres = firstInput[2];
            string town = "";
            if (firstInput.Length==4)
            {
                town = firstInput[3];
            }
            if (firstInput.Length == 5)
            {
                town = firstInput[3]+ " " +firstInput[4];
            }

            Threeuple<string, string, string> personInformation = new Threeuple<string, string, string>(personName, addres, town);

            string[] secondInput = Console.ReadLine()
                .Split();
            string name = secondInput[0];
            string litersOfBeer = secondInput[1];
            string drunkOrNot = secondInput[2];
            bool IsDrink = true;
            if (drunkOrNot == "drunk")
            {
                IsDrink = true;
            }
            else if (drunkOrNot == "not")
            {
                IsDrink = false;
            }

            Threeuple<string, string, bool> personDrinkInformation = new Threeuple<string, string, bool>(name, litersOfBeer, IsDrink);

            string[] thirdInput = Console.ReadLine()
                .Split();
            string clientName = thirdInput[0];
            double accountBallance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            Threeuple<string, double, string> personBankInformation = new Threeuple<string, double, string>(clientName, accountBallance, bankName);

            Console.WriteLine(personInformation);
            Console.WriteLine(personDrinkInformation);
            Console.WriteLine(personBankInformation);
        }
    }
}
