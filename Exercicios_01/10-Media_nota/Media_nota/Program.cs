using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_nota
{
    /*
    Calcule a média de quatro notas e determine se o aluno foi aprovado ou reprovado. Considera-se aprovado quem tem média maior ou igual a 7.
    •	Entrada: 6.5, 8, 7, 9
    •	Saída esperada: Aprovado
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 4: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Aprovado com média: {media:F2}");
            }
            else
            {
                Console.WriteLine($"Reprovado com média: {media:F2}");
            }
        }
    }
}
