using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie  um sistema de menu em cada opção cadastre um item, controlando o acesso do teclado*/
            int opcao = 1;

            while (opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
████╗░████║██╔════╝████╗░██║██║░░░██║
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
                Console.ResetColor();
                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine("1- Cadastro de CLiente");
                Console.WriteLine("2- Cadastro de Fornecedor");
                Console.WriteLine("3- Cdastro de Funcionários");
                Console.WriteLine("4- Cadastro de Cliente");
                Console.WriteLine("5- Cadastro do Pedido");
                Console.WriteLine("0- Sair");
                Console.WriteLine("Escolha uma das opções: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção Inválida, Digite novamente");
                }

                switch (opcao)
                {
                    case 1:
                        Cliente();
                        break;
                    case 2:
                        Fornecedor();
                        break;
                    case 3:
                        Funcionario();
                        break;
                    case 4:
                        Produto();
                        break;
                    case 5:
                        Pedido();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, Tente Novamente");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
        static void Cliente()
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Cliente {nome} Cadastrado com sucesso!");
        }
        static void Fornecedor()
        {
            Console.WriteLine("Cadastro de Fornecedor");
            Console.WriteLine("Digite o código do fornecedor");
            string codigoFornecedor = (Console.ReadLine());
            Console.WriteLine($"Fornecedor {codigoFornecedor} Cadastrado com sucesso");
        }
        static void Funcionario()
        {
            Console.WriteLine("Cadastro de Funcionários");
            Console.WriteLine("Digite o nome do funcionário");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine($"Funcionário {nomeFuncionario} Cadastrado com sucesso!!");
        }
        static void Produto()
        {
            Console.WriteLine("\nCadastro do Produto");
            Console.WriteLine("Digite o nome do produto");
            string Produto = (Console.ReadLine());
            Console.WriteLine($"Produto {Produto} Cadastrado com sucesso!!");
        }
        static void Pedido()
        {
            Console.WriteLine("\nCadastro do Pedido");
            Console.WriteLine("Digite o código do Pedido");
            string codigoPedido = (Console.ReadLine());
            Console.WriteLine($"Pedido {codigoPedido} Cadastrado com sucesso!!");
        }
    }
}
