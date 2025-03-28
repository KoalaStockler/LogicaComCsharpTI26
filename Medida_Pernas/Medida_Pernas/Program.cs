using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medida_Pernas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double medidaPernaDireita, medidaPernaEsquerda;

            Console.WriteLine("Medida da perna direita: ");
            medidaPernaDireita = double.Parse(Console.ReadLine());

            Console.WriteLine("Medida da perna esquerda: ");
            medidaPernaEsquerda = double.Parse(Console.ReadLine());

            if(medidaPernaDireita > medidaPernaEsquerda)
            {
                Console.WriteLine("Cotó na perna esquerda");
            }
            else if(medidaPernaEsquerda > medidaPernaDireita)
            {
                Console.WriteLine("Cotó na perna direita");
            }
            else
            {
                Console.WriteLine("normal");
            }
        }
    }
}
