using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_postivo_ou_negativo
{
    //3. Número positivo, negativo ou zero Dado um número, determine se ele é positivo, negativo ou zero.

    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Digite um numero: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Numero positivo");
            }

            else if (numero < 0) 
            {
                Console.WriteLine("Numero negativo");
            }

            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
