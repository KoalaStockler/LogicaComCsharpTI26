using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01valores_inteiros_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
            //caso contrário devera multiplicar A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
            //imprimir seu valor na tela.

            {

                Console.Title = "Exercício 1";
                Console.ForegroundColor = ConsoleColor.Blue;          

                Console.WriteLine(@"   
                ╔════════════════════════════════════════════════════════════════════════════╗
                ║   __      __   _                       _       _       _                   ║
                ║   \ \    / /  | |                     (_)     | |     (_)                  ║
                ║    \ \  / /_ _| | ___  _ __ ___  ___   _ _ __ | |_ ___ _ _ __ ___  ___     ║
                ║     \ \/ / _` | |/ _ \| '__/ _ \/ __| | | '_ \| __/ _ \ | '__/ _ \/ __|    ║
                ║      \  / (_| | | (_) | | |  __/\__ \ | | | | | ||  __/ | | | (_) \__ \    ║
                ║       \/ \__,_|_|\___/|_|  \___||___/ |_|_| |_|\__\___|_|_|  \___/|___/    ║
                ║                                                                            ║
                ╚════════════════════════════════════════════════════════════════════════════╝
                    ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, \ndeverá somar os dois valores, caso contrário devera multiplicar A por B.Ao final de qualquer um dos cálculos deve-se \natribuir o resultado a uma variável C eimprimir seu valor na tela.");
                Console.ResetColor();

                int a, b, c;

                Console.Write("\nDigite o primeiro numero: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                b = int.Parse(Console.ReadLine());

                if (a == b)
                {
                    c = a + b;
                    Console.WriteLine("Resultado: " + c);
                }
                else
                {
                    c = a * b;
                    Console.WriteLine("Resultado: " + c);
                }
            }
        }
    }
}

