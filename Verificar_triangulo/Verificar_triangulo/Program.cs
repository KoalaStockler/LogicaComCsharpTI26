using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;

            while (true)
            {
                Console.Write("Digite o primeiro lado do triângulo: ");
                if (double.TryParse(Console.ReadLine(), out lado1) && lado1 > 0)
                    break;
                Console.WriteLine("Valor inválido! Digite um número positivo.");
            }

            while (true)
            {
                Console.Write("Digite o segundo lado do triângulo: ");
                if (double.TryParse(Console.ReadLine(), out lado2) && lado2 > 0)
                    break;
                Console.WriteLine("Valor inválido! Digite um número positivo.");
            }

            while (true)
            {
                Console.Write("Digite o terceiro lado do triângulo: ");
                if (double.TryParse(Console.ReadLine(), out lado3) && lado3 > 0)
                    break;
                Console.WriteLine("Valor inválido! Digite um número positivo.");
            }

            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                if (lado1 == lado2 && lado1 == lado3)
                    Console.WriteLine("O triângulo é equilátero.");
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    Console.WriteLine("O triângulo é isósceles.");
                else
                    Console.WriteLine("O triângulo é escaleno.");
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo válido.");
            }
        }
    }
}
