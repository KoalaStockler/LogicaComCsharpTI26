using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos_básicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, soma, subtracao, divisao, multiplicacao;

            Console.Write("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            divisao = numero1 / numero2;

            Console.WriteLine("soma: " + soma + "\nsubtracao: " + subtracao + "\nmultiplicacao: " + multiplicacao + "\ndivisao: " + divisao);
        }
    }
}
