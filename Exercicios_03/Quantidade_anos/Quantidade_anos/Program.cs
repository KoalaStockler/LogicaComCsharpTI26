using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade_anos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int anoNascimento, anoAtual, idadeAnos, idadeMeses, idadeDias;

                Console.Write("Digite o ano de nascimento: ");
                anoNascimento = int.Parse(Console.ReadLine());

                Console.Write("Digite o ano atual: ");
                anoAtual = int.Parse(Console.ReadLine());

                idadeAnos = anoAtual - anoNascimento;
                idadeMeses = idadeAnos * 12;
                idadeDias = idadeAnos * 365;

                // Imprimir idade em anos, meses e dias
                Console.WriteLine("Você tem " + idadeAnos + " anos, " + idadeMeses + " meses e " + idadeDias + " dias de vida.");
            }
        }

    }

