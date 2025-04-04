using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04dois_valores_booleanos
{
    internal class Program
    {
        static void Main(string[] args)
        // Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.
        {
            Console.Title = "Exercício 4";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"   
                ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
                ║                                                                                                                                       ║
                ║     ____  _____  ____  ___    _  _  __    __    _____  ____  ____  ___    ____  _____  _____  __    ____    __    _  _  _____  ___    ║
                ║    (  _ \(  _  )(_  _)/ __)  ( \/ )/__\  (  )  (  _  )(  _ \( ___)/ __)  (  _ \(  _  )(  _  )(  )  ( ___)  /__\  ( \( )(  _  )/ __)   ║
                ║     )(_) ))(_)(  _)(_ \__ \   \  //(__)\  )(__  )(_)(  )   / )__) \__ \   ) _ < )(_)(  )(_)(  )(__  )__)  /(__)\  )  (  )(_)( \__ \   ║
                ║    (____/(_____)(____)(___/    \/(__)(__)(____)(_____)(_)\_)(____)(___/  (____/(_____)(_____)(____)(____)(__)(__)(_)\_)(_____)(___/   ║
                ║                                                                                                                                       ║    
                ║                                                                                                                                       ║
                ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.");

            Console.ResetColor();
            bool valor1, valor2;

            Console.Write("\nDigite true para (Verdadeiro) ou false para (Falso): ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro true para (Verdadeiro) ou false para (Falso): ");
            valor2 = bool.Parse(Console.ReadLine());

            if (valor1 == true && valor2 == true)
            {
                 Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}
