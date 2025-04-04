using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07valor_A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
            //Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
        {
            Console.Title = "Exercício 7";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"   
                ╔════════════════════════════════════════════════════════════════════════════╗            
                ║                      _                                   ____              ║
                ║                     | |                  /\             |  _ \             ║
                ║          __   ____ _| | ___  _ __       /  \      ___   | |_) |            ║
                ║          \ \ / / _` | |/ _ \| '__|     / /\ \    / _ \  |  _ <             ║
                ║           \ V / (_| | | (_) | |       / ____ \  |  __/  | |_) |            ║
                ║            \_/ \__,_|_|\___/|_|      /_/    \_\  \___|  |____/             ║     
                ║                                                                            ║
                ╚════════════════════════════════════════════════════════════════════════════╝
                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.");
            Console.ResetColor();

            double A, B;

            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine(" invertendo os valores, o valor de A é: " + B + "\n e o valor de B é: " + A);

        }
    }
}
