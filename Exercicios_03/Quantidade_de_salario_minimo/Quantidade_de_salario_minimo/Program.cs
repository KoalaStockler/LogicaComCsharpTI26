using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade_de_salario_minimo
{

    /*
     2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário,        calcule quantos salários mínimos esse 
        usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioMinimo = 1518;
            double salarioUsuario;
            double qtdSalarioMinimo;

            Console.Write("Digite o salario: ");
            salarioUsuario = double.Parse(Console.ReadLine());

                qtdSalarioMinimo = (int) (salarioUsuario / salarioMinimo);
                Console.WriteLine("Salario usuario: " + salarioUsuario + "\nSalario minimo " + salarioMinimo + "\nQuantidade de salario minimo: " + qtdSalarioMinimo);

        }
    }
}
