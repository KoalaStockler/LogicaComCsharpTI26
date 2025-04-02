using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_de_dinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write("Digite o valor: ");
            valor = int.Parse(Console.ReadLine());

            if (valor >= 100)
            {
                Console.WriteLine("1 nota de 100");
                valor -= 100;
            }
            if (valor >= 50)
            {
                Console.WriteLine("1 nota de 50");
                valor -= 50;
            }
            if (valor >= 20)
            {
                Console.WriteLine("1 nota de 20");
                valor -= 20;
            }
            if (valor >= 10)
            {
                Console.WriteLine("1 nota de 10");
                valor -= 10;
            }
            if (valor >= 5)
            {
                Console.WriteLine("1 nota de 5");
                valor -= 5;
            }
            if (valor >= 2)
            {
                Console.WriteLine("1 nota de 2");
                valor -= 2;
            }
            if (valor >= 1)
            {
                Console.WriteLine("1 nota de 1");
                valor -= 1;
            }
        }
    }
}
