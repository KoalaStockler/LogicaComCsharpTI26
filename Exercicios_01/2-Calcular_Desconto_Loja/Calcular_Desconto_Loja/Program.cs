using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Desconto_Loja
{
    /*
    5. Calcular desconto
    Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário, o desconto é de 5%. Dado o preço, calcule o valor do desconto.
    •	Entrada: 120
    •	Saída esperada: 12 reais de desconto
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, descontoPreco;

            Console.Write("Digite o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());

            if (precoProduto > 100)
            {
                descontoPreco = precoProduto * 0.10;
                Console.WriteLine(descontoPreco + " reais de desconto");
            }
            else 
            {
                descontoPreco = precoProduto * 0.5;
                Console.WriteLine(descontoPreco + " reais de desconto");
            }
        }
    }
}
