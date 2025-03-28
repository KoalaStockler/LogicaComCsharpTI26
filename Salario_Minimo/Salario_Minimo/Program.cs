using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_Minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).

            double salarioMinimo = 1528, salarioUser, QTDsalarios;

            Console.WriteLine("Informe seu salário: ");
            salarioUser = double.Parse(Console.ReadLine());

                QTDsalarios = (int) (salarioUser / salarioMinimo);
                Console.WriteLine("Quantidade de salários minímos: " + QTDsalarios);        
        }
    }
}
