using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_numero_negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Digite um numero: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if(numero< 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
