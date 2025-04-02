using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_liquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita os dados ao usuário
            Console.Write("Digite o valor da hora-aula (em R$): ");
            double horaAula = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de aulas lecionadas no mês: ");
            int numeroAulas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o percentual de desconto do INSS (%): ");
            double percentualINSS = Convert.ToDouble(Console.ReadLine());

            // Calcula o salário bruto
            double salarioBruto = horaAula * numeroAulas;

            // Calcula o desconto do INSS
            double descontoINSS = salarioBruto * (percentualINSS / 100);

            // Calcula o salário líquido
            double salarioLiquido = salarioBruto - descontoINSS;

            // Concatenando a resposta com o valor do salário
            Console.WriteLine("O salário líquido do professor é R$ " + salarioLiquido.ToString("F2") + ".");
        }
    }
}
