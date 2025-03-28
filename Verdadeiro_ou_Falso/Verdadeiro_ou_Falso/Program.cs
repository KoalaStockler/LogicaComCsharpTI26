using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdadeiro_ou_Falso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valor1, valor2;

            Console.WriteLine("Digite um valor um boolean: ");
            valor1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor boolean: ");
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
