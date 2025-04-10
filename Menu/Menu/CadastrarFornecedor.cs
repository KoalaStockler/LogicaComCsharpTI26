using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarFornecedor
    {
        public static void Fornecedor()
        {
            Console.WriteLine("Cadastro de Fornecedor");
            Console.WriteLine("Digite o código do fornecedor");
            string codigoFornecedor = (Console.ReadLine());
            Console.WriteLine($"Fornecedor {codigoFornecedor} Cadastrado com sucesso");
        }
    }
}
