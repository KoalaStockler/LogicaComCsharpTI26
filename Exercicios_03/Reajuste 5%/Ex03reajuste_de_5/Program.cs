using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03reajuste_de_5
{
    internal class Program
    {
        static void Main(string[] args)
        // Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.
        {
            Console.Title = "Exercício 3";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"   
                ╔════════════════════════════════════════════════════════════════════════╗             
                ║                      _           _             _        _____ _   __   ║    
                ║                     (_)         | |           | |      | ____(_) / /   ║
                ║       _ __ ___  __ _ _ _   _ ___| |_ ___    __| | ___  | |__    / /    ║
                ║      | '__/ _ \/ _` | | | | / __| __/ _ \  / _` |/ _ \ |___ \  / /     ║
                ║      | | |  __/ (_| | | |_| \__ \ ||  __/ | (_| |  __/  ___) |/ / _    ║
                ║      |_|  \___|\__,_| |\__,_|___/\__\___|  \__,_|\___| |____//_/ (_)   ║
                ║                   _/ |                                                 ║
                ║                  |__/                                                  ║                        
                ╚════════════════════════════════════════════════════════════════════════╝
                    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.");

            Console.ResetColor();

            double valor, reajuste;

            Console.Write("Digite o valor para ser ajustado em 5%: ");
            valor = double.Parse(Console.ReadLine());

            reajuste = (valor * 0.05) + valor;

            Console.WriteLine("O valor sem o reajuste: " + valor + "\n Valor com o reajuste de 5%: " + reajuste);
        }
    }
}
