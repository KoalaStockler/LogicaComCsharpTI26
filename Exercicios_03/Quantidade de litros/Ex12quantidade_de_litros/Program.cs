using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12quantidade_de_litros
{
    internal class Program
    {
        static void Main(string[] args)
        //Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem, sabendo que o carro faz 12km com um litro.
        //Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média, distância percorrida e a quantidade de litros utilizados para fazer a viagem.
        //Fórmula: distância = tempo x velocidade.
        //litros usados = distância / 12.

        {
            Console.Title = "Exercício 12";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"   
                ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗
                ║                                                                                                       ║
                ║                              _   _     _           _            _        _ _ _                        ║
                ║                             | | (_)   | |         | |          | |      | (_) |                       ║
                ║       __ _ _   _  __ _ _ __ | |_ _  __| | __ _  __| | ___    __| | ___  | |_| |_ _ __ ___  ___        ║
                ║      / _` | | | |/ _` | '_ \| __| |/ _` |/ _` |/ _` |/ _ \  / _` |/ _ \ | | | __| '__/ _ \/ __|       ║    
                ║     | (_| | |_| | (_| | | | | |_| | (_| | (_| | (_| |  __/ | (_| |  __/ | | | |_| | | (_) \__ \       ║
                ║      \__, |\__,_|\__,_|_| |_|\__|_|\__,_|\__,_|\__,_|\___|  \__,_|\___| |_|_|\__|_|  \___/|___/       ║   
                ║         | |                                                                                           ║
                ║         |_|                                                                                           ║  
                ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝
                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem, sabendo que o carro faz 12km com um litro. Deve - se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média, distância percorrida e a quantidade de litros utilizados para fazer a viagem.");
                        Console.ResetColor();
            double tempo, velocidadeMedia, distancia, litrosDeGasolina;
            Console.WriteLine("\nDigite o tempo da viagem (em horas): ");
             tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média (em km/h): ");
            velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            // Calcula a distância percorrida
            distancia = tempo * velocidadeMedia;

            // Calcula a quantidade de litros gastos (considerando 12 km por litro)
            litrosDeGasolina = distancia / 12;

            // Concatenando a resposta com a quantidade de litros
            Console.WriteLine("A quantidade de litros gastos na viagem foi " + litrosDeGasolina.ToString("F2") + " litros.");

        }
    }
}
