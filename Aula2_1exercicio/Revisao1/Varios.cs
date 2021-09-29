using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao1
{

    /// <summary>
    /// Contem métodos de análise de arrays
    /// </summary>
    class Varios
    {
        

        #region CriaArray
        /// <summary>
        /// Cria um array de inteiros a partir dos dados inseridos pelo utilizador
        /// </summary>
        /// <param name="dados"></param>
        /// <returns>Devolve Array preenchido</returns>
        public static int[] CriaArray(int[] dados)
        {
            for(int n=0; n<4; n++)
            {
                string s = Console.ReadLine();
                dados[n] = int.Parse(s);

            }
            return dados;
        }

        #endregion



        #region MaiorValorArray
        /// <summary>
        /// Devolve o maior valor inserido num array
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public static int MaiorValorArray(int[] dados) {
            int n = 0;
            int m = dados[n];//!<Variável que armazena o maior valor

            for (n=0; n < 3; n++)
            {

                if (m < dados[n + 1])
                    m = dados[n + 1];
                else
                    continue;

            }
             return m;
}

        #endregion



        #region MyToUpper

        #endregion
    }
}
