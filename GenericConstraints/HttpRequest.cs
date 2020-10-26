using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericConstraints
{
    //Така слагаме на Т-то констрейнт да е само клас
    public class HttpRequest<T> where T : MarshalByRefObject
    {
        public void Send<О>(T data, О operation)
            where О: Т //където О наследява Т , т.е. можем да чейнваме типовете (казваме горе че Т е MarshalByRefObject и после че О наследява Т) т.е. можем да правим констрейнти и на методи.
            //Най-често констрейнти се използват за интерфейси, това е най=полезното нещо което съществува!!!
        {
            data.
            Console.WriteLine("Sendingall the data to the www" + data);
        }
    }
}
