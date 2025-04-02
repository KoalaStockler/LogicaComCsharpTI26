using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posicao_de_um_numero
{
    internal class Program
    {
 //Dado um número, verifique se ele está na faixa de 1 a 10, 11 a 20 ou acima de 20.
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <=10) 
            {
                Console.WriteLine("1 a 10");
            }
            else if(numero >= 11 && numero <= 20)
            {
                Console.WriteLine("11 a 20");
            }
            else if(numero > 20)
            {
                Console.WriteLine("Acima de 20");
            }
            else
            {
                Console.WriteLine("ERRO, digite um numero valido");
            }
        }
    }
}
