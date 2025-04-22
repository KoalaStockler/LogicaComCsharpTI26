using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_bandas
{
    internal class CadastrarBanda
    {
        public static void Banda()
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
