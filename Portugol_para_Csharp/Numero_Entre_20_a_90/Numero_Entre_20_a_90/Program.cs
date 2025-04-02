using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Entre_20_a_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 20 && numero < 90)
            {
                Console.WriteLine("Numero esta entre 20 e 90");
            }
            else
            {
                Console.WriteLine("Numero não esta entre 20 e 90");
            }
        }
    }
}
