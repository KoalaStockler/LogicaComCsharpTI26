using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maioridade_penal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade < 18)
            {
                Console.Write("Menor de idade penal");
            }
            else
            {
                Console.Write("Maior de idade penal");
            }
        }
    }
}
