using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Lab
{
    public class GenericList
    {
        //Тук <Т> може да се сложи или горе на класа и класа да е дженерик, или така след името на метода и дженерик е само метода - зависи от нуждата!
        public bool Contains<T>(List<T> list, T element)
        {
            return list.Contains(element);
        }
    }
}
