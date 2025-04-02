using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antecessor_sucessor_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, numeroSucessor, numeroAntecessor;

            Console.Write("Digite o numero: ");
            numero = int.Parse(Console.ReadLine());

            numeroAntecessor = numero - 1;
            numeroSucessor = numero + 1;

            Console.WriteLine("Antecessor: " + numeroAntecessor);
            Console.WriteLine("Numero: " + numero);
            Console.WriteLine("Sucessor: " + numeroSucessor);

        }
    }
}
