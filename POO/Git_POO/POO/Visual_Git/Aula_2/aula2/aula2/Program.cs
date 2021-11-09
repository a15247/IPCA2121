using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 5, 1, 3, 2, 2 };

            //int MaiorValorArray = Class1.MaiorValor(v);

            //Console.WriteLine(MaiorValorArray);

            int[] arrayOrdenado = Calculo.OrdenaArray(v);
            
            Console.WriteLine("Array Ordenado\n");
            
            foreach (int valores in arrayOrdenado)
                Console.Write($"{valores} ");
            
            Console.ReadLine();
        }
    }
}
