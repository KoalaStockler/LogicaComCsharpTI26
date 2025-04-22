using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_de_bandas;
using Estacionamento_de_Shopping;
using Menu_de_Atividades.Exercicios_01;

namespace Menu_de_Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
█▀▄▀█ █▀▀ █▄░█ █░█   █▀▄ █▀▀   ▄▀█ ▀█▀ █ █░█ █ █▀▄ ▄▀█ █▀▄ █▀▀ █▀
█░▀░█ ██▄ █░▀█ █▄█   █▄▀ ██▄   █▀█ ░█░ █ ▀▄▀ █ █▄▀ █▀█ █▄▀ ██▄ ▄█");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMenu de Atividades");
                Console.ResetColor();
                Console.WriteLine("1 - Cadastro de Bandas");
                Console.WriteLine("2 - Estacionamento de Shopping");
                Console.WriteLine("3 - Exercícios 01");
                Console.WriteLine("4 - Exercícios 02");
                Console.WriteLine("5 - Exercícios 03");
                Console.WriteLine("6 - Menu de Cadastro");
                Console.WriteLine("0 - Finalizar programa");
                Console.Write("Escolha uma opção: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Opção Inválida, tente novamente: ");
                    Console.ResetColor();
                }

                switch (opcao)
                {
                    case 1:
                        CadastroBandas.Cadastro();
                        break;

                    case 2:
                        EstacionamentoShopping.Estacionamento();
                        break;

                    case 3:
                        ExecutarEx01.Ex01();
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nFinalizando o programa...");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida, tente novamente");
                        Console.ResetColor();
                        break;
                }

                if (opcao != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }       
        }
    }
}
