using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_2_centimetros_por_ano
{
    internal class Program
    {
        static void Main(string[] args)
            //Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m
            //e cresce 3 centímetros por ano.Faça um algoritmo que calcule e imprima na tela em quantos anos serão necessários para que Francisco seja maior que Sara.
        {
            Console.Title = "Exercício 10";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"   
                ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
                ║                                                                                                                   ║
                ║                     _   _                _                                                                        ║    
                ║                    | | (_)              | |                                                                       ║
                ║       ___ ___ _ __ | |_ _ _ __ ___   ___| |_ _ __ ___  ___   _ __   ___  _ __    __ _ _ __   ___                  ║
                ║      / __/ _ \ '_ \| __| | '_ ` _ \ / _ \ __| '__/ _ \/ __| | '_ \ / _ \| '__|  / _` | '_ \ / _ \                 ║
                ║     | (_|  __/ | | | |_| | | | | | |  __/ |_| | | (_) \__ \ | |_) | (_) | |    | (_| | | | | (_)                  ║
                ║      \___\___|_| |_|\__|_|_| |_| |_|\___|\__|_|  \___/|___/ | .__/ \___/|_|     \__,_|_| |_|\___/                 ║
                ║                                                             | |                                                   ║
                ║                                                             |_|                                                   ║
                ║                                                                                                                   ║
                ║                                                                                                                   ║    
                ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
                    ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m e cresce 3 centímetros por ano.Faça um algoritmo que calcule e imprima na tela em quantos anos serão necessários para que Francisco seja maior que Sara.");
                  
            Console.ResetColor();

            double alturaFrancisco = 1.50, alturaSara = 1.10, anos = 0, CrescimentoPorAnoF = 0.02, CrescimentoPorAnoS = 0.03, i=0 , calculoDiferenca;
            while (alturaFrancisco >= alturaSara)
            {
                alturaFrancisco += CrescimentoPorAnoF; // Francisco cresce
                alturaSara += CrescimentoPorAnoS;           // Sara cresce
                anos++;                                   // Incrementa anos
            }
                Console.WriteLine("Serão necessários " + anos + " Anos para sara ultrapassar francisco");
        }
            
        }
    }

