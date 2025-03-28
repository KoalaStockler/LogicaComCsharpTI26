using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinco_porcento_de_um_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.

            double valor, reajuste;

            Console.WriteLine("Informe um valor: ");
            valor = double.Parse(Console.ReadLine());

            reajuste = (valor * 0.05) + valor;
            Console.WriteLine("Refazendo o reajuste de 5% ficaria: " + reajuste);
        }
    }
}
