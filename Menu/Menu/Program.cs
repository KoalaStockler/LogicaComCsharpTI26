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
                        CadastrarCliente.Cliente();
                        break;
                    case 2:
                        CadastrarFornecedor.Fornecedor();
                        break;
                    case 3:
                        CadastrarFuncionario.Funcionario();
                        break;
                    case 4:
                        CadastrarProduto.Produto();
                        break;
                    case 5:
                        CadastrarPedido.Pedido();
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
    }
}
