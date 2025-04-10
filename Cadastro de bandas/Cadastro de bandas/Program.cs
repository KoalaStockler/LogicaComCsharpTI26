using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_bandas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crie um sistema de cadastro de álbuns de um artista / banda em que será possivel cadastrar um número X de músicas informada pelo usuário. Crie um menu de opções para isso.
            */
            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMenu de Cadastro");
                Console.ResetColor();
                Console.WriteLine("1 - Cadastro do Artista");
                Console.WriteLine("2 - Cadastro da Banda");
                Console.WriteLine("0 - Finalizar programa");
                Console.Write("Escolha uma opção: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Opção Inválida, digite novamente: ");
                    Console.ResetColor();
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarArtista.Artista();
                        break;
                    case 2:
                        CadastrarBanda.Banda();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nSaindo do programa...");
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