using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarProduto
    {
        public static void Produto()
        {
            Console.WriteLine("\nCadastro do Produto");
            Console.WriteLine("Digite o nome do produto");
            string Produto = (Console.ReadLine());
            Console.WriteLine($"Produto {Produto} Cadastrado com sucesso!!");
        }
    }
}
