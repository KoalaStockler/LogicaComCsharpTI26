using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historico_de_pedidos
{
    internal class Program
    {
        // Desenvolva um programa que armazene o histórico de compras de 100 clientes e mostre o total gasto por cada cliente.
        static void Main(string[] args)
        {
            double[,] compras = new double[100, 5];

            for (int i = 0; i < 100; i++)
            {
                double total = 0;
                Console.WriteLine($"\nCompras do cliente {i + 1}:");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Valor da compra {j + 1}: R$ ");
                    compras[i, j] = double.Parse(Console.ReadLine());
                    total += compras[i, j];
                }

                Console.WriteLine($"Total gasto pelo cliente {i + 1}: R$ {total:0.00}");
            }
        }
    }
}
