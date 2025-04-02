using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_da_Semana
{
    /**
    Dia da semana
    Determine se o dia informado é um dia útil ou final de semana
    * Entrada: 6(sabado)
    * Saída esperada: Final de semana
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaSemana;

            Console.Write("Digite o numero da semana: ");
            diaSemana = int.Parse(Console.ReadLine());

            if (diaSemana > 7)
            {
                Console.WriteLine("Dia da semana invalida, tente novamente");
            }
            else if (diaSemana == 1 || diaSemana == 7)
            {
                Console.WriteLine("Final de semana");
            }
            else
            {
                Console.WriteLine("Dia da semana normal");
            }
        }
    }
}