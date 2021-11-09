using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Calculo
    {
        
        /// <summary>
        /// Calcula a soma entre X e Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Calcula a subtração entre X e Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Subtracao(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Calcula a multiplicação entre X e Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Calcula a divisão entre X e Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static float Divisao(int x, int y)
        {
            return (float)x / y;
        }
        
    }

}

