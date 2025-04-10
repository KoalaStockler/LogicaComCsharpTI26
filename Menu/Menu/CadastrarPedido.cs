using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarPedido
    {
        public static void Pedido()
        {
            Console.WriteLine("\nCadastro do Pedido");
            Console.WriteLine("Digite o código do Pedido");
            string codigoPedido = (Console.ReadLine());
            Console.WriteLine($"Pedido {codigoPedido} Cadastrado com sucesso!!");
        }
    }
}
