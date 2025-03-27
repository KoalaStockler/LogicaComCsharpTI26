using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_de_Nascimento_com_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que pergunte sua idade e responda o ano que você nasceu. O programa deverá permanecer perguntando idades até que o usuário digite como a idade o número 0 (zero)
            int idade, contador, ano_atual;

            for(contador = 1; contador > 0; contador++)
            {
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());

                Console.WriteLine("Seu ano de nascimento é: " + (ano_atual - idade));

                if (idade == 0)
                {
                    Console.Write("Fim do programa, idade 0");
                    break;
                }
            }
        }
    }
}
