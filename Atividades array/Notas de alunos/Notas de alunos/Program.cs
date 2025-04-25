using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_de_alunos
{
    internal class Program
    {
        // Crie um programa que armazene as notas de 30 alunos e calcule a média da turma.
        static void Main(string[] args)
        {
            double[] notas = new double[30];
            double soma = 0;

            for (int i = 0; i < 30; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];
            }

            Console.WriteLine("Média da turma: " + (soma / 30));
        }
    }
}
