﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_entre_3_numeros
{

    /*
     Maior número
     1. Dado três números, determine qual é o maior entre eles.
     •	Entrada: 5, 12, 8
     •	Saída esperada: 12
    */

    internal class MaiorEntre3Numeros
    {
        public static void Maior3Num()
        {
            double numero1, numero2, numero3;

            Console.Write("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            numero3 = int.Parse(Console.ReadLine());


            if (numero1 > numero2 && numero1 > numero3) 
            {
                Console.WriteLine("Maior numero: " + numero1);
            }

            else if (numero2 > numero1 && numero2 > numero3) 
            {
                Console.WriteLine("Maior numero: " + numero2);
            }
            else 
            {
                Console.WriteLine("Maior numero " + numero3);
            }
       
        }
    }
}
