using System;

namespace Exercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1 = "Hello World";
            string palavra2 = "Hello   World,  Sr   Edu?";
             
            Console.WriteLine(Class1.ToUpper(palavra1));

            Console.WriteLine(Class1.TrimString(palavra2));
        }
    }
}
