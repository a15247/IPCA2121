using System;

namespace Project1
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int soma = Calculo.Soma(x, y);
            int subtracao = Calculo.Subtracao(x, y);
            int multiplicacao = Calculo.Multiplicacao(x, y);
            float divisao = Calculo.Divisao(x, y);
            Console.WriteLine("{0} + {1} = {2}", x, y, soma );
            Console.WriteLine("{0} + {1} = {2}", x, y, subtracao);
            Console.WriteLine("{0} + {1} = {2}", x, y, multiplicacao);
            Console.WriteLine("{0} + {1} = {2}", x, y, divisao);
            Console.ReadKey();
        }
    }
}
