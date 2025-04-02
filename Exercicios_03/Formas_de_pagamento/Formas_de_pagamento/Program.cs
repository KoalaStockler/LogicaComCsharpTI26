using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_de_pagamento
{
    /*
     1-	Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a escolha da forma de pagamento
        pelo comprador e imprima na tela o valor final do produto a ser pago. Utilize os códigos da tabela de condições de pagamento para
        efetuar o cálculo adequado.
 
        Tabela de Código de Condições de Pagamento
 
        1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
        2 - À Vista no cartão de crédito, recebe 10% de desconto
        3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
        4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            double valorProduto, valorDesconto, valorJuros;
            int opcaoPagamento = 0;

            const ConsoleColor FONTCOLORGREEN = ConsoleColor.Green;
            const ConsoleColor FONTCOLORYELLOW = ConsoleColor.Yellow;
            const ConsoleColor FONTCOLORBLUE = ConsoleColor.Blue;
            const ConsoleColor FONTCOLORRED = ConsoleColor.Red;

                
            Console.ForegroundColor = FONTCOLORYELLOW;
            Console.WriteLine("\r\n  __  __   ___   _  _   _   _     ___    ___      ___    ___    ___    /\\/|  ___   ___ \r\n |  \\/  | | __| | \\| | | | | |   |   \\  | __|    / _ \\  | _ \\  / __|  |/\\/  | __| / __|\r\n | |\\/| | | _|  | .` | | |_| |   | |) | | _|    | (_) | |  _/ | (__  / __ \\ | _|  \\__ \\\r\n |_|  |_| |___| |_|\\_|  \\___/    |___/  |___|    \\___/  |_|    \\___| \\____/ |___| |___/\r\n                                                                )_)                    \r\n");
            Console.ResetColor();

            Console.WriteLine("FORMAS DE PAGAMENTO\n" + "1 - Á Vista em dinheiro ou pix, recebe 15% de desconto\n" +
                "2 - Á Vista no cartão de crédito, recebe 10% de desconto\n" +
                "3 - Parcelando no cartão de em duas vezes, preço normal do produto sem juros\n" +
                "4 - Parcelando no cartão em três vezes ou mais, preço normal do produto mais juros de 10%\n" +
                "5 - Sair do programa\n"
                );

            Console.Write("Opção de pagamento: ");
            opcaoPagamento = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcaoPagamento)
            {
                case 1:
                    Console.WriteLine("Á Vista em dinheiro ou pix, recebe 15% de desconto");
                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");

                    valorProduto = double.Parse(Console.ReadLine());
                    valorDesconto = valorProduto - (valorProduto * 0.15);

                    Console.ResetColor();
                    Console.ForegroundColor = FONTCOLORGREEN;

                    Console.WriteLine("Valor do produto com desconto: R$ " + valorDesconto);
                    Console.ResetColor();
                    break;

                case 2:
                    Console.WriteLine("Á Vista no cartão de crédito, recebe 10% de desconto");
                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");

                    valorProduto = double.Parse(Console.ReadLine());
                    valorDesconto = valorProduto - (valorProduto * 0.10);
                    Console.ForegroundColor = FONTCOLORYELLOW;

                    Console.ResetColor();
                    Console.ForegroundColor = FONTCOLORGREEN;
                    Console.WriteLine("Valor do produto com desconto: R$" + valorDesconto);
                    Console.ResetColor();
                    break;

                case 3:
                    Console.WriteLine("Parcelado no cartão em duas vezes, preço normal do produto sem juros");

                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");
                    valorProduto = double.Parse(Console.ReadLine());
                    double valorParcelas = valorProduto / 2;

                    Console.ResetColor();

                    Console.ForegroundColor = FONTCOLORBLUE;
                    Console.WriteLine("Valor da 1 parcela: R$" + valorParcelas);
                    Console.WriteLine("Valor da 2 parcela: R$" + valorParcelas);

                    Console.ResetColor();

                    Console.ForegroundColor = FONTCOLORGREEN;
                    Console.WriteLine("Total: R$" + valorProduto);
                    break;

                case 4:
                    Console.WriteLine("Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%");

                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");

                    valorProduto = int.Parse(Console.ReadLine());
                    valorJuros = valorProduto + (valorProduto * 0.10);

                    Console.ForegroundColor = FONTCOLORGREEN;
                    Console.WriteLine("Total: " + valorJuros);
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = FONTCOLORRED;
                    Console.WriteLine("Saindo do programa...");
                    Console.ResetColor();
                    break;

                default:
                    Console.WriteLine("Digite a opção corretamente, tente novamente");
                    break;
            }

        
        }
    }
}
