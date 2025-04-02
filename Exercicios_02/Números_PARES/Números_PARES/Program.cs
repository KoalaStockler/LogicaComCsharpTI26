using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_PARES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            for (contador = 2; contador <= 100; contador++)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador + "\n");
                }
            }
        }
    }
}
