using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_de_votacao
{
    internal class Program
    {
        // Implemente uma estrutura para armazenar as notas de 5 jurados para cada um dos 10 participantes de uma competição e calcule a média final de cada participante.
        static void Main(string[] args)
        {
            double[,] notas = new double[10, 5];

            for (int i = 0; i < 10; i++)
            {
                double soma = 0;
                Console.WriteLine($"\nNotas do participante {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Nota do jurado {j + 1}: ");
                    notas[i, j] = double.Parse(Console.ReadLine());
                    soma += notas[i, j];
                }

                Console.WriteLine($"Média: {(soma / 5):0.00}");
            }
        }
    }
}
