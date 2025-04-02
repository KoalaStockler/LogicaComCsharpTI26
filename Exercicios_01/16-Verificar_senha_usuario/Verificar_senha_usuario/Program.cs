using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_senha_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senhaUsuario;
            int tamanhoSenha;

            Console.Write("Digite a sua senha: ");
            senhaUsuario = Console.ReadLine();

            tamanhoSenha = senhaUsuario.Length;

            if (tamanhoSenha < 8)
            {
                Console.WriteLine("A senha deve ter 8 caracteres, tente novamente !");
            }

            // Verifica se a senha contém pelo menos uma letra
            // Verifica se a senha contém pelo menos um número
            else if (senhaUsuario.Any(char.IsLetter) && senhaUsuario.Any(char.IsDigit))
            {
                Console.WriteLine("Senha valida");
            }
            else
            {
                Console.WriteLine("Senha invalida");
            }
        }
    }
}
