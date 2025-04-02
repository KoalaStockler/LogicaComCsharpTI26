using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores_boolean
{

    /*
     4-	Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            bool valor1, valor2;

            Console.Write("Digite um valor boolean (true/false): ");
            valor1 = bool.Parse(Console.ReadLine());


            Console.Write("Digite outro valor boolean (true/false): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

        }
    }
}
