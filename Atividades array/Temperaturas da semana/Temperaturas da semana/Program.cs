using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas_da_semana
{
    internal class Program
    {
        // Crie um algoritmo que armazene as temperaturas diárias de uma cidade durante uma semana e informe o dia mais quente e o mais frio.
        static void Main(string[] args)
        {
            double[] temperaturas = new double[7];
            string[] dias = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            double max = double.MinValue, min = double.MaxValue;
            int diaMax = 0, diaMin = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Temperatura de {dias[i]}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());

                if (temperaturas[i] > max) { max = temperaturas[i]; diaMax = i; }
                if (temperaturas[i] < min) { min = temperaturas[i]; diaMin = i; }
            }

            Console.WriteLine($"Dia mais quente: {dias[diaMax]} ({max}°C)");
            Console.WriteLine($"Dia mais frio: {dias[diaMin]} ({min}°C)");
        }
    }
}
