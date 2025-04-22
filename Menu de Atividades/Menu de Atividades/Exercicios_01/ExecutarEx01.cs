using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ano_Bissexto;
using Calcular_Desconto_Loja;
using Comparar_dois_numeros;
using Compra_de_ingresso;
using Dia_da_Semana;
using Encontrar_menor_numero;
using Idade_para_dirigir;
using Maior_entre_3_numeros;
using Maioridade_Penal;
using Media_nota;
using Notas_de_dinheiro;
using Numero_postivo_ou_negativo;
using Posicao_de_um_numero;
using Verificar_numero_multiplo_3_ou_5;
using Verificar_perna_maior;
using Verificar_senha_usuario;
using Verificar_temperatura;
using Verificar_triangulo;

namespace Menu_de_Atividades.Exercicios_01
{
    internal class ExecutarEx01
    {
        public static void Ex01()
        {
            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
█▀▄▀█ █▀▀ █▄░█ █░█   █▀▄ █▀▀   ▄▀█ ▀█▀ █ █░█ █ █▀▄ ▄▀█ █▀▄ █▀▀ █▀
█░▀░█ ██▄ █░▀█ █▄█   █▄▀ ██▄   █▀█ ░█░ █ ▀▄▀ █ █▄▀ █▀█ █▄▀ ██▄ ▄█");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMenu de Atividades");
                Console.ResetColor();
                Console.WriteLine("1 - Ano Bissexto");
                Console.WriteLine("2 - Calcular desconto da loja");
                Console.WriteLine("3 - Comparar dois números");
                Console.WriteLine("4 - Compra de Ingresso");
                Console.WriteLine("5 - Dia da Semana");
                Console.WriteLine("6 - Encontrar menor número");
                Console.WriteLine("7 - Idade para dirigir");
                Console.WriteLine("8 - Maior entre 3 números");
                Console.WriteLine("9 - Maioridade penal");
                Console.WriteLine("10 - Media nota");
                Console.WriteLine("11 - Notas de dinheiro");
                Console.WriteLine("12 - Número positivo ou negativo");
                Console.WriteLine("13 - Posição de um número");
                Console.WriteLine("14 - Verificar número de 3 ou 5");
                Console.WriteLine("15 - Verificar Perna Maior");
                Console.WriteLine("16 - Verificar senha usúario");
                Console.WriteLine("17 - Verificar temperatura");
                Console.WriteLine("18 - Verificar triângulo");
                Console.WriteLine("0 - Finalizar programa");
                Console.Write("Escolha uma opção: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Opção Inválida, tente novamente: ");
                    Console.ResetColor();
                }

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        AnoBissexto.Bissexto();
                        break;

                    case 2:
                        Console.Clear();
                        CalcularDesconto.Desconto();
                        break;

                    case 3:
                        Console.Clear();
                        ComparaNumeros.Numero();
                        break;

                    case 4:
                        Console.Clear();
                        CompraIngresso.Ingresso();
                        break;

                    case 5:
                        Console.Clear();
                        DiaSemana.DaySem();
                        break;

                    case 6:
                        Console.Clear();
                        MenorNumero.MenorNum();
                        break;

                    case 7:
                        Console.Clear();
                        IdadeParaDirigir.Dirigir();
                        break;

                    case 8:
                        Console.Clear();
                        MaiorEntre3Numeros.Maior3Num();
                        break;

                    case 9:
                        Console.Clear();
                        MaioridadePenal.Maioridade();
                        break;

                    case 10:
                        Console.Clear();
                        MediaNota.MediaNot();
                        break;

                    case 11:
                        Console.Clear();
                        NotasDinheiro.Money();
                        break;

                    case 12:
                        Console.Clear();
                        NumeroPositivoNegativo.PositivoNegativo();
                        break;

                    case 13:
                        Console.Clear();
                        PosicaoNumero.PosNum();
                        break;

                    case 14:
                        Console.Clear();
                        Multiplo3ou5.Multiplo();
                        break;

                    case 15:
                        Console.Clear();
                        PernaMaior.Perna();
                        break;

                    case 16:
                        Console.Clear();
                        SenhaUser.Senha();
                        break;

                    case 17:
                        Console.Clear();
                        Temperatura.Temp();
                        break;

                    case 18:
                        Console.Clear();
                        VerificarTriangulo.Triangulo();
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nFinalizando o programa...");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida, tente novamente");
                        Console.ResetColor();
                        break;
                }

                if (opcao != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }
    }
}
