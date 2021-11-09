using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1
{
    class Calculo
    {
        static void mostrarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static int MaiorValorArray(int[] array)
        {
            int ValorMaior = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > ValorMaior)
                {
                    ValorMaior = array[i];
                }
            }
            return  ValorMaior;
        }
    }
}
