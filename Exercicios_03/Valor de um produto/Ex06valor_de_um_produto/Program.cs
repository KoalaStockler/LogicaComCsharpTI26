using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ex06valor_de_um_produto
{
    internal class Program
    {
        static void Main(string[] args)
         //Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento
         //pelo comprador e imprima na tela o valor final do produto a ser pago.Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.

         //Tabela de Código de Condições de Pagamento
 
         //1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
         //2 - À Vista no cartão de crédito, recebe 10% de desconto
         //3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
         //4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%

        {
            Console.Title = "Exercício 6";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
               ╔═════════════════════════════════════════════════════════════════════════════════════════════════════╗
               ║                                                                                                     ║    
               ║                                                                                                     ║    
               ║                _                  _                                              _       _          ║
               ║               | |                | |                                            | |     | |         ║      
               ║    __   ____ _| | ___  _ __    __| | ___   _   _ _ __ ___    _ __  _ __ ___   __| |_   _| |_ ___    ║    
               ║    \ \ / / _` | |/ _ \| '__|  / _` |/ _ \ | | | | '_ ` _ \  | '_ \| '__/ _ \ / _` | | | | __/ _ \   ║
               ║     \ V / (_| | | (_) | |    | (_| |  __/ | |_| | | | | | | | |_) | | | (_) | (_| | |_| | || (_) |  ║
               ║      \_/ \__,_|_|\___/|_|     \__,_|\___|  \__,_|_| |_| |_| | .__/|_|  \___/ \__,_|\__,_|\__\___/   ║
               ║                                                             | |                                     ║
               ║                                                             |_|                                     ║
               ╚═════════════════════════════════════════════════════════════════════════════════════════════════════╝ ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFaça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento \n pelo comprador e imprima na tela o valor final do produto a ser pago.");
            Console.ResetColor();

            double valorProduto, valorAserPago;
            string formaDePagamento;

            Console.Write("Digite o valor a ser pago: ");
            valorProduto = double.Parse(Console.ReadLine());

            Console.Write(" 1-(a vista em Dinheiro) \n 2-(a vista no Pix) \n 3-(a vista no cartão de crédito)\n 4-(Parcelado no cartão em duas vezes)\n 5-(Parcelado no cartão em três vezes) \nDigite a forma de pagamento: ");
            formaDePagamento = Console.ReadLine();

            if(formaDePagamento == "1" || formaDePagamento == "2")
            {
                valorAserPago = valorProduto - (valorProduto * 0.15);
                Console.WriteLine("Valor total com desconto: " + valorAserPago);
            }
            else if (formaDePagamento == "3")
            {
                valorAserPago = valorProduto - (valorProduto * 0.10);
                Console.WriteLine("Valor total com desconto: " + valorAserPago);
            }
            else if (formaDePagamento == "4" )
            {
                valorAserPago = valorProduto;
                Console.WriteLine("Valor total: " + valorAserPago);
            }
            else if (formaDePagamento == "5")
            {
                valorAserPago = valorProduto + (valorProduto * 0.10);
                Console.WriteLine("Valor total: " + valorAserPago);
            }
            else
            {
                Console.WriteLine("Forma de pagamento inválida");
            }
        }
    }
}
