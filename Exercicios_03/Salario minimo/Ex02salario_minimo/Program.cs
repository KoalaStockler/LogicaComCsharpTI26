using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Exercício 2";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"
                ╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗ 
                ║                         /$$                     /$$                               /$$           /$$                         ║
                ║                        | $$                    |__/                              |__/          |__/                         ║
                ║      /$$$$$$$  /$$$$$$ | $$  /$$$$$$   /$$$$$$  /$$  /$$$$$$        /$$$$$$/$$$$  /$$ /$$$$$$$  /$$ /$$$$$$/$$$$   /$$$$$$  ║
                ║     /$$_____/ |____  $$| $$ |____  $$ /$$__  $$| $$ /$$__  $$      | $$_  $$_  $$| $$| $$__  $$| $$| $$_  $$_  $$ /$$__  $$ ║
                ║    |  $$$$$$   /$$$$$$$| $$  /$$$$$$$| $$  \__/| $$| $$  \ $$      | $$ \ $$ \ $$| $$| $$  \ $$| $$| $$ \ $$ \ $$| $$  \ $$ ║
                ║     \____  $$ /$$__  $$| $$ /$$__  $$| $$      | $$| $$  | $$      | $$ | $$ | $$| $$| $$  | $$| $$| $$ | $$ | $$| $$  | $$ ║
                ║     /$$$$$$$/|  $$$$$$$| $$|  $$$$$$$| $$      | $$|  $$$$$$/      | $$ | $$ | $$| $$| $$  | $$| $$| $$ | $$ | $$|  $$$$$$/ ║ 
                ║    |_______/  \_______/|__/ \_______/|__/      |__/ \______/       |__/ |__/ |__/|__/|__/  |__/|__/|__/ |__/ |__/ \______/  ║                                                                          
                ║                                                                                                                             ║
                ╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFaça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse \nusuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).\n");

            Console.ResetColor();

            double salarioMinimo = 1518, salarioUsuario, quantidadeDeSalario;

            Console.Write("Digite o seu salário: ");
            salarioUsuario = double.Parse(Console.ReadLine());


            quantidadeDeSalario = (int) (salarioUsuario / salarioMinimo);

            Console.WriteLine("Você recebe " + quantidadeDeSalario + " Salários mínimos");
        }
    }
}
