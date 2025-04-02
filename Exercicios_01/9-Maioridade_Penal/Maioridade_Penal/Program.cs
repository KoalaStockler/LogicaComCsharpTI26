using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maioridade_Penal
{
    /*
    Maioridade penal 
    Determine se uma pessoa atingiu a maioridade penal, que ocorre
    aos 18 anos no Brasil;
    * Entrada 17
    * Saida esperada: Menor de idade penal    
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18) 
            {
                Console.WriteLine("Menor de idade penal");
            }
            else
            {
                Console.WriteLine("Maior de idade penal");
            }
        }
    }
}
