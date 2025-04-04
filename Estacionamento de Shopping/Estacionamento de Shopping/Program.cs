using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_de_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crie um sistema de controle de estacionamento para um shopping. O estacionamento tem um limite de 100 vagas, e o objetivo é gerenciar a entrada e saída dos carros, além de avisar quando o estacionamento estiver cheio.

            Requisitos do sistema:

            - O estacionamento deve permitir a entrada de carros até o limite de 100 vagas.

            - Se o estacionamento estiver cheio, não será possível registrar a entrada de novos carros.

            - Quando um carro sai, a vaga é liberada, permitindo a entrada de um novo carro.

            - O sistema precisa controlar a quantidade de vagas ocupadas e dar avisos quando o estacionamento estiver quase cheio (80% de capacidade) ou completamente cheio (100%). 
            */

            int vagasTotais = 100, vagasOcupadas = 0;
            string opcao;

            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
        ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗    
        ║   _____ _     _                             _        _____             _             _            _        _____    _             _                                        _         ║
        ║  /  ___(_)   | |                           | |      /  __ \           | |           | |          | |      |  ___|  | |           (_)                                      | |        ║
        ║  \ `--. _ ___| |_ ___ _ __ ___   __ _    __| | ___  | /  \/ ___  _ __ | |_ _ __ ___ | | ___    __| | ___  | |__ ___| |_ __ _  ___ _  ___  _ __   __ _ _ __ ___   ___ _ __ | |_ ___   ║
        ║   `--. \ / __| __/ _ \ '_ ` _ \ / _` |  / _` |/ _ \ | |    / _ \| '_ \| __| '__/ _ \| |/ _ \  / _` |/ _ \ |  __/ __| __/ _` |/ __| |/ _ \| '_ \ / _` | '_ ` _ \ / _ \ '_ \| __/ _ \  ║
        ║  /\__/ / \__ \ ||  __/ | | | | | (_| | | (_| |  __/ | \__/\ (_) | | | | |_| | | (_) | |  __/ | (_| |  __/ | |__\__ \ || (_| | (__| | (_) | | | | (_| | | | | | |  __/ | | | || (_) | ║
        ║  \____/|_|___/\__\___|_| |_| |_|\__,_|  \__,_|\___|  \____/\___/|_| |_|\__|_|  \___/|_|\___|  \__,_|\___| \____/___/\__\__,_|\___|_|\___/|_| |_|\__,_|_| |_| |_|\___|_| |_|\__\___/  ║
        ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
                                                                                                                                                                                   
");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n                                                                                Vagas Ocupadas: " + vagasOcupadas + "/" + vagasTotais + " (" + (vagasOcupadas * 100 / vagasTotais) + "%)");
                Console.ResetColor();

                if (vagasOcupadas == vagasTotais)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                                                                Estacionamento CHEIO!");
                }
                else if (vagasOcupadas >= 80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("                                                                                Estacionamento quase cheio! (80% ou mais ocupado)");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                                                                                Vagas disponíveis.");
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n                                                                                ══════════ MENU ══════════");
                Console.ResetColor();
                Console.WriteLine("                                                                                1 - Entrada de carro");
                Console.WriteLine("                                                                                2 - Saída de carro");
                Console.WriteLine("                                                                                3 - Sair do sistema");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n                                                                                Digite sua opção: ");
                Console.ResetColor();
                opcao = Console.ReadLine();

                Console.WriteLine();

                if (opcao == "1")
                {
                    if (vagasOcupadas < vagasTotais)
                    {
                        vagasOcupadas++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                                                                                Carro entrou. Vaga ocupada com sucesso.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                                                                                Estacionamento cheio. Entrada negada.");
                    }
                }
                else if (opcao == "2")
                {
                    if (vagasOcupadas > 0)
                    {
                        vagasOcupadas--;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                                                                                Carro saiu. Vaga liberada.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("                                                                                Nenhum carro para sair.");
                    }
                }
                else if (opcao == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                                                                                Encerrando o sistema... Até logo!");
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                                                                Opção inválida! Tente novamente.");
                }

                Console.ResetColor();
                Console.WriteLine("\n                                                                                Pressione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}
