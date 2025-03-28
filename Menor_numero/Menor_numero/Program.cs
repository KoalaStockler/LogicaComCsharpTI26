using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.Write("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());


            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            numero3 = int.Parse(Console.ReadLine());



            if(numero1 <= numero2 && numero1 <= numero3)
            {
                Console.Write(numero1);
            }
            else if(numero2 <= numero1 && numero2 <= numero3) 
            {
                Console.Write(numero2);
            }
            else
            {
                Console.Write(numero3);
            }
        }
    }
}
