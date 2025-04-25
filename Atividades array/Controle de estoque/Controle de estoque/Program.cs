using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_estoque
{
    internal class Program
    {
        // Implemente um sistema que armazene a quantidade de 50 produtos em estoque e informe o produto com maior e menor quantidade disponível.
        static void Main(string[] args)
        {
            int[] estoque = new int[50];
            int max = int.MinValue, min = int.MaxValue, prodMax = 0, prodMin = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"Quantidade do produto {i + 1}: ");
                estoque[i] = int.Parse(Console.ReadLine());

                if (estoque[i] > max) { max = estoque[i]; prodMax = i; }
                if (estoque[i] < min) { min = estoque[i]; prodMin = i; }
            }

            Console.WriteLine($"Produto com maior estoque: {prodMax + 1} ({max})");
            Console.WriteLine($"Produto com menor estoque: {prodMin + 1} ({min})");
        }
    }
}
