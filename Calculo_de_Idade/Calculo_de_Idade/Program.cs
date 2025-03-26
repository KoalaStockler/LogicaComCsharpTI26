using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano_atual, ano_nascimento, idade;
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu ano de nascimento: ");
            ano_nascimento = int.Parse(Console.ReadLine());

            idade = ano_atual - ano_nascimento;
            Console.Write("Idade: " + idade);
        }
    }
}
