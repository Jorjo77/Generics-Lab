using System;
using System.Security.Cryptography.X509Certificates;

namespace Generics_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics - <T> може да е всякакъв тип данни и има методите на object - единственото общо м/у всеки тип данни е това че наследява object !!!
            //Примерен клас Generic (Operations):
            //Така един и същи метод работи и с инт и със стринг - това е така защото използваме дженерик (правим динамичен типа който използваме)!!! Така се получава код, който можем да преизползваме.
            //Интересно е че можем да изброяваме колкото си искаме Т типове, например:<Т, Т2, Т3, Т4, Т5>
            //Но и тук ще трябва да подадем нужния брой типове : var operation = new Operations<int, string, double, int, int>();
            //По честия случай е с 2 Т -та! Taka можем на всяка инстанция на класа да си избираме типовете с които да работим. Листа, Стака, Кюто са типични дженетици!!!

            //Метод е дженерик когато приема параметър дженерик
            //Статичен клас също може да бъде дженерик. Дженерици се ползват САМО когато има смисъл, иначе е излишно, прави кода малко по нечетим (трябва да се замисляме какви са типовете, т.е. има си и минуси дженерика, но когато е използван правилно е нещо много мощно!) 
            //С Рефлекшън можем да форийчваме всички пропъртита на един клас! 
            //Можем да имаме дженерик метод без да имаме дженерик клас, метода приема дженерик и връща дженерик! Просто след името на метода казваме че искаме да използваме Т, 
            // Пример: PublicKey List<T> CreateList<T>(T item) 

            // string.Join работи с масив от обекти, като му подадеш обекта по следния начин:
            //string.Join<StartUp>(", ", array)

            //Constraints (ограничения) се подават с where:
            //PublicKey void MyMethod<T>()
            //    where T : class - за референтни типове
            //PublicKey void MyMethod<T>()
            //    where T : class- за примитивни типове
            //можем да кажем кой е базовия клас от който Т -то тръгва
            //IComparable е интерфейс който има метода CompareTo

            //Най-често констрейнти се използват за интерфейси, това е най=полезното нещо което съществува!!!

            //var operation = new Operations<int, string>();
            //Console.WriteLine(operation.AreEqual(5, "5"));
            //Console.WriteLine(operation.ToStringResult(5, "6"));
            //operation.First = 6;

            //var stringOperation = new Operations<string, int>();
            //stringOperation.First = "shest";
            //Console.WriteLine(stringOperation.ToStringResult("hop", 5));

            //var operation = new Operations<int>();
            //Console.WriteLine(operation.AreEqual(5, 6));
            //Console.WriteLine(operation.ToStringResult(5, 6));
            //operation.First = 6;

            //var stringOperation = new Operations<string>();
            //stringOperation.First = "shest";
            //Console.WriteLine(stringOperation.ToStringResult("hop", "trop"));

            int number = Print<int>(5);
            string text= Print<string>("text");
            Program program = Print<Program>(new Program());
        }
        static T Print<T>(T value)
        {
            T value2 = value;
            Console.WriteLine(value);   //5
                                        //text
                                        //Generics_Lab.Program
            return value;
        }

    }
    class Operations<TFirst, TSecond>
    //можем да подаваме повече Т типове на класа: class Operations<T, Т2, Т3, Т4, Т5>
    {

        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public bool AreEqual(TFirst first, TSecond second)
        {
            return first.Equals(second);
        }

        public string ToStringResult(TFirst first, TSecond second)
        {
            return first.ToString() + second.ToString();
        }

        //private T first;
        //private T second;
        //public T First { get; set; }
        //public T Second { get; set; }

        //public bool AreEqual(T first, T second)
        //{
        //    return first.Equals(second);
        //}

        //public string ToStringResult(T first, T second)
        //{
        //    return first.ToString() + second.ToString();
        //}
    }
}
