using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarCliente
    {
        public static void Cliente()
        {
            Console.WriteLine("\nCadastro de Cliente");
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Cliente {nome} Cadastrado com sucesso!");
        }
    }
}
