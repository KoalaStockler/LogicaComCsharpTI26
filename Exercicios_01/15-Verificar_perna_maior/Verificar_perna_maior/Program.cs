using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_perna_maior
{
    /*
     2. Crie um algoritmo para verificar se o Keno possui uma perna mais curta que a outra, peça a medida exata de cada perna 
     e verifique a metragem exibindo as seguintes possibilidades de mensagem: Cotó na perna esquerda, 
    cotó na perna direita ou normal.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double medidaPernaDireita, medidaPernaEsquerda;

            Console.Write("Medida da perna direita: ");
            medidaPernaDireita = double.Parse(Console.ReadLine());

            Console.Write("Medida da perna esquerda: ");
            medidaPernaEsquerda = double.Parse(Console.ReadLine());

            if (medidaPernaDireita > medidaPernaEsquerda) 
            {
                Console.WriteLine("Cotó na perna esquerda");
            }
            else if (medidaPernaEsquerda > medidaPernaDireita) 
            {
                Console.WriteLine("Cotó na perna direira");
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }
    }
}
