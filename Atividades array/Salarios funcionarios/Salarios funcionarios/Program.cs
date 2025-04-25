using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios_funcionarios
{
    internal class Program
    {
        // Implemente um sistema que armazene os salários de 50 funcionários e calcule a média salarial da empresa.
        static void Main(string[] args)
        {
            double[] salarios = new double[50];
            double soma = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"Salário do funcionário {i + 1}: R$ ");
                salarios[i] = double.Parse(Console.ReadLine());
                soma += salarios[i];
            }

            Console.WriteLine("Média salarial da empresa: R$ " + (soma / 50).ToString("0.00"));
        }
    }
}
