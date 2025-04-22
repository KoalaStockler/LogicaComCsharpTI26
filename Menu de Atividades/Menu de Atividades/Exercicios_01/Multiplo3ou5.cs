using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_numero_multiplo_3_ou_5
{
    //Vericar se um numero é multiplo de 3 ou 5
    internal class Multiplo3ou5
    {
        public static void Multiplo()
        {
            int numero;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0 || numero % 5 == 0) 
            {
                Console.WriteLine("Multiplo de 3 ou 5");
            }
            else
            {
                Console.WriteLine("Não é multiplo de 3 ou 5");
            }

        }
    }
}
