using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09temperatura_em_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        //Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius.Imprima na tela as duas temperaturas.
        //Fórmula: C = (5 * (F - 32) / 9)

        {
            Console.Title = "Exercício 9";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"   
                ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
                ║                                                                                                                                                        ║   
                ║           _                                      _                                      ______    _                    _          _ _                  ║   
                ║          | |                                    | |                                    |  ____|  | |                  | |        (_) |                 ║
                ║          | |_ ___ _ __ ___  _ __   ___ _ __ __ _| |_ _   _ _ __ __ _    ___ _ __ ___   | |__ __ _| |__  _ __ ___ _ __ | |__   ___ _| |_                ║
                ║          | __/ _ \ '_ ` _ \| '_ \ / _ \ '__/ _` | __| | | | '__/ _` |  / _ \ '_ ` _ \  |  __/ _` | '_ \| '__/ _ \ '_ \| '_ \ / _ \ | __|               ║
                ║          | ||  __/ | | | | | |_) |  __/ | | (_| | |_| |_| | | | (_| | |  __/ | | | | | | | | (_| | | | | | |  __/ | | | | | |  __/ | |_                ║
                ║           \__\___|_| |_| |_| .__/ \___|_|  \__,_|\__|\__,_|_|  \__,_|  \___|_| |_| |_| |_|  \__,_|_| |_|_|  \___|_| |_|_| |_|\___|_|\__|               ║
                ║                            | |                                                                                                                         ║ 
                ║                            |_|                                                                                                                         ║
                ║                                                                                                                                                        ║   
                ║                                                                                                                                                        ║
                ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFaça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius.Imprima na tela as duas temperaturas.");
                        
            Console.ResetColor();

            double temperaturaFarenheit, temperaturaCelcius;

            Console.Write("Digite a temperatura em farenheit: ");
            temperaturaFarenheit = double.Parse(Console.ReadLine());

            temperaturaCelcius = (5 * (temperaturaFarenheit - 32) / 9);

            Console.WriteLine("A temperatura de " + temperaturaFarenheit + " Farenheit transformado em graus celcius é de: " + temperaturaCelcius + " Graus celcius");
        }
    }
}
