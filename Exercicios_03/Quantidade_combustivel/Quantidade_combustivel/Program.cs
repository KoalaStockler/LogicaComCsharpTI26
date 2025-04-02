using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade_combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita os dados ao usuário
            Console.Write("Digite o tempo da viagem (em horas): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média (em km/h): ");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            // Calcula a distância percorrida
            double distancia = tempo * velocidadeMedia;

            // Calcula a quantidade de litros gastos (considerando 12 km por litro)
            double litrosGastos = distancia / 12;

            // Concatenando a resposta com a quantidade de litros
            Console.WriteLine("A quantidade de litros gastos na viagem foi " + litrosGastos.ToString("F2") + " litros.");
        }
    }
}
