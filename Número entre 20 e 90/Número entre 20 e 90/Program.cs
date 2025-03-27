using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_entre_20_e_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Digite um número entre 20 e 90: ");
            numero = Console.Read();

            if (numero > 20 && numero < 90)
            {
                Console.WriteLine("Este número está dentro do compreendido de 20 e 90");
            }
            else
            {
                Console.WriteLine("O número ", numero, " não está dentro do compreendido de 20 e 90");
            }
        }
    }
}
