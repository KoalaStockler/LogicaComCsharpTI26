using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Pares_2_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++) 
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
