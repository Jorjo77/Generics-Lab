using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    //IComparable е интерфейс който има метода CompareTo и тук казва този клас трябва да има метода CompareTo
    //С това , IEnumerable<T> казваме че искаме нашия клас да има и Енумератор (GetEnumerator)
    // така можем да казваме на Т - то какво е, можем да му кажем ти си структора where T:struct
    // constraints for numbers in C# в гугъл и
    //where T : struct, 
    //      IComparable, 
    //      IComparable<T>, 
    //      IConvertible, 
    //      IEquatable<T>, 
    //      IFormattable
    //това гарантира че ще ни въвеждат само числа, полезно е!
    //Но на дженерика не му е това идеята да работи с числа по принцип.
    class Math<T> where T: IComparable<T>
    {
        public T Max(T first, T second)
        {
            if (first.CompareTo(second)>0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
