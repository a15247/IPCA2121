using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp1 = 111.0f;
            float temp2 = 111.0f;

            while (temp1 > 100 || temp1 < -10 || temp2 > 100 || temp2 < -10)
            {
                //Introduzir valores para a conversão
                Console.WriteLine("celsius:");
                temp1 = float.Parse(Console.ReadLine());
                Console.WriteLine("fahrenheit:");
                temp2 = float.Parse(Console.ReadLine());

            }

                   
            //Calculo da conversao de celsius para fahrenheit e vise versa
            float celsius = (temp1 - 32) * 5 / 9;
            float fahrenheit = (temp2 * 9) / 5 + 32;

            //Apresentar resultados
            Console.WriteLine("{0} graus Celcius equivale a {1} graus Fahrenheit", temp1, celsius);
            Console.WriteLine("{0} graus Fahrenheit equivale a {1} graus Celcius", temp2, fahrenheit);

            
        }
    }
}