using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_IMPARES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;

            for (contador = 1; contador <= 100; contador++) 
                {
                if(contador % 2 != 0)
                {
                    Console.WriteLine(contador + "\n");
                }
            }
        }
    }
}
