using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_3_e_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());


            if(numero % 3 == 0 || numero % 5 == 0)
            {
                Console.WriteLine("Multiplo de 3 e 5");
            }
            else
            {
                Console.WriteLine("Não é multiplo de 3 e 5");
            }
        }
    }
}
