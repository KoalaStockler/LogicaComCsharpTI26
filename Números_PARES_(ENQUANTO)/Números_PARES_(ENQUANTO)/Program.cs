using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_PARES__ENQUANTO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorPares = 0;

            while (contadorPares <= 100)
            {
                if (contadorPares % 2 == 0)
                {
                    Console.WriteLine(contadorPares + "\n");
                }
                contadorPares++;
            }
        }
    }
}
