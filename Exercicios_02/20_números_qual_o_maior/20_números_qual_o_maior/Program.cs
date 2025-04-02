using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_números_qual_o_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 	Escreva um programa que leia um conjunto de 20 números inteiros e mostre qual foi o maior valor fornecido pelo usuário programa
            int num, contador, numMaior;


            numMaior = -1;
            contador = 1;


            while(contador <= 20)
            {
                Console.WriteLine("Digite o ", contador, "° número: ");
                num = Console.Read();
                contador++;


                if(num > numMaior)
                    {
                    numMaior = num;
                    }
            }
                Console.Clear();
                Console.WriteLine("O número maior é: ", numMaior);
        }
    }
}
