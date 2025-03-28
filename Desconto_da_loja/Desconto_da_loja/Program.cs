using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_da_loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, descontoPreco;


            Console.WriteLine("Digite o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());

            if(precoProduto > 100)
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
