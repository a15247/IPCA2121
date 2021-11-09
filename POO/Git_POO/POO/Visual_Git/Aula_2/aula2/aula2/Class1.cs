using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Class1
    {
        public static int MaiorValor(int[] v)
        {
            int aux = v[0];
            for (int i = 1; i < v.Length; i++)
            {
                if (aux < v[i])
                {
                     aux= v[i];
                }
            }
            return aux;
        }
    }
    class Calculo
    {
        public static int[] OrdenaArray(int[] v)
        {
            int i, j;
            int N = v.Length;
            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && v[i] < v[i - 1]; i--)
                {
                    TrocarValores(v, i, i - 1);
                }
            }
            return v;
        }

        public static int[] TrocarValores(int[] v, int m, int n)
        {
            int temp;
            temp = v[m];
            v[m] = v[n];
            v[n] = temp;
            return v;
        }
    }
}
