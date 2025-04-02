using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparar_dois_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2) 
            {
                Console.WriteLine("Números iguais");
            }
            else
            {
                Console.WriteLine("Números diferentes");
            }
        }
    }
}
