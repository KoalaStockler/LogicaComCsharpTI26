using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_ou_Multiplica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, caso contrário devera multiplicar A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir seu valor na tela.
            
            int valor1, valor2, resultado;

            Console.WriteLine("Digite um número inteiro: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                resultado = valor1 + valor2;
                Console.WriteLine("Valores iguais então a soma deles é: " + resultado);
            }
            else
            {
                resultado = valor1 * valor2;
                Console.WriteLine("Valores diferentes então a multiplicação deles é: " + resultado);
            }
        }
    }
}
