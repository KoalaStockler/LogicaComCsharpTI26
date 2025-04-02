using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_de_ingresso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorIngresso, valorIngressoDesconto;

            Console.Write("Digite o valor do ingresso: ");
            valorIngresso = double.Parse(Console.ReadLine());

            if (valorIngresso > 200) 
            {
                valorIngressoDesconto = valorIngresso - (valorIngresso * 0.10);
                Console.WriteLine(valorIngressoDesconto + " reais");
            }
            else
            {
                Console.WriteLine("Ingresso não possui desconto");
            }
        }
    }
}
