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
                        Artista();
                        break;
                    case 2:
                        Banda();
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

        static void Artista()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro de Artista");
            Console.ResetColor();

            Console.Write("Digite o nome do artista: ");
            string artista = Console.ReadLine();

            Console.Write("Digite o nome do álbum: ");
            string album = Console.ReadLine();

            int musicas;
            Console.Write($"Informe quantas músicas quer adicionar no álbum '{album}': ");

            while (!int.TryParse(Console.ReadLine(), out musicas) || musicas < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dado inválido, digite novamente: ");
                Console.ResetColor();
            }

            List<string> listaMusicas = new List<string>();

            for (int i = 1; i <= musicas; i++)
            {
                Console.Write($"Escreva o nome da música {i}: ");
                string nomeMusica = Console.ReadLine();
                listaMusicas.Add(nomeMusica);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nArtista '{artista}' com o álbum '{album}' e {musicas} música(s) cadastrada(s) com sucesso!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nLista de músicas do álbum '{album}':");
            Console.ResetColor();

            for (int i = 0; i < listaMusicas.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {listaMusicas[i]}");
            }
        }

        static void Banda()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cadastro da Banda");
            Console.ResetColor();

            Console.Write("Digite o nome da banda: ");
            string banda = Console.ReadLine();

            Console.Write("Digite o nome do álbum: ");
            string album = Console.ReadLine();

            int musicas;
            Console.Write($"Informe quantas músicas quer adicionar no álbum '{album}': ");

            while (!int.TryParse(Console.ReadLine(), out musicas) || musicas < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dado inválido, digite novamente: ");
                Console.ResetColor();
            }

            List<string> listaMusicas = new List<string>();

            for (int i = 1; i <= musicas; i++)
            {
                Console.Write($"Escreva o nome da música {i}: ");
                string nomeMusica = Console.ReadLine();
                listaMusicas.Add(nomeMusica);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nBanda '{banda}' com o álbum '{album}' e {musicas} música(s) cadastrada(s) com sucesso!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nLista de músicas do álbum '{album}':");
            Console.ResetColor();

            for (int i = 0; i < listaMusicas.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {listaMusicas[i]}");
            }
        }
    }
}