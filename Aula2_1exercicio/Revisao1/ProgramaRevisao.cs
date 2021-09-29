/**
 * \Nome: Sérgio
 * \Data: 28-09-2021
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao1
{
    /// <summary>
    /// Classe principal
    /// </summary>
    class ProgramaRevisao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 4 inteiros:");

            int[] dados = new int[4];

            dados = Varios.CriaArray(dados);

            int maior = Varios.MaiorValorArray(dados);

            Console.WriteLine("Maior Valor:{0}", maior.ToString());

            Console.ReadKey();
        }

    }
  

}
