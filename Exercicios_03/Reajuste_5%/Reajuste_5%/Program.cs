using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste_5_
{
    /*
      Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor, valorReajustado;

            Console.Write("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor normal: " + valor);
            valorReajustado = (valor * 0.05) + valor;

            Console.WriteLine("Valor reajustado: " + valorReajustado);
        }
    }
}
