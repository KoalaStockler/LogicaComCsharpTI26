using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.Write("Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (5 * (fahrenheit - 32 ) / 9);
            Console.WriteLine("Celsius: " + celsius.ToString("F2"));
        }
    }
}
