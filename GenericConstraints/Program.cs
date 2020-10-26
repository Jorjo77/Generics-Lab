using System;
using System.IO;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            //сега HttpRequest<StreamReader> работи защото StreamReader наследява MarshalByRefObject
            HttpRequest<StreamReader> request = new HttpRequest<StreamReader>();
        }
    }
}
