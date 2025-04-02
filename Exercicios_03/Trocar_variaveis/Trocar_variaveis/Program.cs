using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trocar_variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, temp;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            // Trocar os valores de A e B
            temp = A;
            A = B;
            B = temp;

            // Imprimir os valores trocados
            Console.WriteLine("Após a troca, o valor de A é: " + A + " e o valor de B é: " + B);
        }
    }
}
