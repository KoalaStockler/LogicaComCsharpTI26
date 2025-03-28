using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.Write("Digite ano: ");
            ano = int.Parse(Console.ReadLine());

            if(ano % 4 == 0 && ano % 100 != 0)
            {
                Console.Write("Ano bissexto");
            }
            else if(ano% 400 == 0)
            {
                Console.Write("Ano bissexto");
            }
            else
            {
                Console.Write("Não bissexto");
            }
        }
    }
}
