using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_temperatura
{
    //Dada uma temperatura, determine se o clima está "Frio", "Ameno" ou "Quente". A classificação segue a seguinte tabela:
    /*  
    Menor que 15°C: Frio
    Entre 15°C e 25°C: Ameno
    Maior que 25°C: Quente
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (temperatura < 15)
            {
                Console.WriteLine("Está frio ");
            }
            else if (temperatura >= 15 && temperatura <= 25)
            {
                Console.WriteLine("Está ameno ");
            }
            else
            {
                Console.WriteLine("Está quente ");
            }
        }
    }
}
