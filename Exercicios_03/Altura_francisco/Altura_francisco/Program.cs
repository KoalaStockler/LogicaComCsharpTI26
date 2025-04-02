using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altura_francisco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializa as variáveis de altura e crescimento
            double franciscoAltura = 1.50;  // em metros
            double saraAltura = 1.10;  // em metros
            double franciscoCrescimento = 0.02;  // em metros por ano (2 cm)
            double saraCrescimento = 0.03;  // em metros por ano (3 cm)

            // Contador de anos
            int anos = 0;

            // Loop até Francisco ultrapassar Sara em altura
            while (franciscoAltura <= saraAltura)
            {
                franciscoAltura += franciscoCrescimento;
                saraAltura += saraCrescimento;
                anos++;
            }

            // Concatenando a resposta com o número de anos
            Console.WriteLine("Francisco será maior que Sara em " + anos + " anos.");
        }
    }
}
