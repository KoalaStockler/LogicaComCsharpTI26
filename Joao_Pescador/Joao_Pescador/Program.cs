using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joao_Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, sobra;

            Console.WriteLine("Digite o peso pescasdo: ");
            peso = double.Parse(Console.ReadLine());
            sobra = (peso - 50) * 4;
            Console.WriteLine(sobra);
        }
    }
}
