using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_entre_3_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ifgundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            numero3 = int.Parse(Console.ReadLine());


            if(numero1 > numero2)
            {
                if(numero1 > numero3)
                {
                    Console.WriteLine(numero1);
                }
            }
            else if(numero2 > numero3)
            {
                if(numero2 > numero1)
            {
                    Console.WriteLine(numero2);
            }
            }
            else
            {
                Console.WriteLine(numero3);
            }
        }
    }
}
