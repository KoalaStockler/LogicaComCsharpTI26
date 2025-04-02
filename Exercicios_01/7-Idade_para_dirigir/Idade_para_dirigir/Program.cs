using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_para_dirigir
{
    /*
    Idade para dirigir
    Verifique se uma pessoa tem idade suficiente para obter a carteira de motorista
    considerando que a idade minima é 18 anos
    *Entrada 17
    Saida esperada: Não pode dirigir
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18) 
            {
                Console.WriteLine("Não pode dirigir");
            }
            else
            {
                Console.WriteLine("Pode dirigir");
            }
        }
    }
}
