using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_entre_1_a_100
{
    internal class Program
    {
        // Crie um programa que armazene os números de 1 a 100 em um array e calcule a soma desses números.
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            int soma = 0;

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = i + 1;
                soma += numeros[i];
            }

            Console.WriteLine("Soma de 1 a 100: " + soma);
        }
    }
}
