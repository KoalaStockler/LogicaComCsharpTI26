using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_de_produtos
{
    internal class Program
    {
        // Desenvolva um sistema que armazene os preços de 10 produtos e aplique um desconto de 10% em todos os preços.
        static void Main(string[] args)
        {
            double[] precos = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Preço do produto {i + 1}: R$ ");
                precos[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPreços com 10% de desconto:");
            for (int i = 0; i < precos.Length; i++)
            {
                double comDesconto = precos[i] * 0.9;
                Console.WriteLine($"Produto {i + 1}: R$ {comDesconto:0.00}");
            }
        }
    }
}
