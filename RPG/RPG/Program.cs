using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    internal class Program
    {
        public class Ficha
        {
            public string nomeDoJogador;
            public string nomeDoPersonagem;
            public string raca;
            public string classe;
            public int vida;

            public void imprimirFicha()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Nome do jogador: {nomeDoJogador}");
                Console.WriteLine($"Nome do personagem: {nomeDoPersonagem}");
                Console.WriteLine($"Raça: {raca}");
                Console.WriteLine($"Classe: {classe}");
                Console.WriteLine($"Vida: {vida}");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int d6Player;
            int d6Inimigo;

            Ficha personagemPrincipal = new Ficha();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite o nome do jogador: ");
            Console.ResetColor();
            personagemPrincipal.nomeDoJogador = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite o nome do personagem: ");
            Console.ResetColor();
            personagemPrincipal.nomeDoPersonagem = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a raça do personagem: ");
            Console.ResetColor();
            personagemPrincipal.raca = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a classe do personagem: ");
            Console.ResetColor();
            personagemPrincipal.classe = Console.ReadLine();

            personagemPrincipal.vida = 100;

            Console.Clear();
            personagemPrincipal.imprimirFicha();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====== AVENTURA COMEÇA ======");
            Console.ResetColor();
            Console.WriteLine("Você está bebendo em uma taverna.");
            Console.WriteLine("Uma pessoa esbarra em você. O que você faz?");
            Console.WriteLine("[ 1 ] Se virar.");
            Console.WriteLine("[ 2 ] Continuar como se nada tivesse acontecido.");

            string decisao = Console.ReadLine();

            if (decisao == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nAgora começa a treta!");
                Console.ResetColor();

                Ficha lautrecHumanoInimigo = new Ficha()
                {
                    nomeDoJogador = "NPC",
                    nomeDoPersonagem = "Lautrec",
                    raca = "Humano",
                    classe = "Clérigo",
                    vida = 80
                };

                lautrecHumanoInimigo.imprimirFicha();
                Console.WriteLine("\n");

                while (lautrecHumanoInimigo.vida > 0 && personagemPrincipal.vida > 0)
                {
                    d6Player = random.Next(1, 6);
                    d6Inimigo = random.Next(1, 6);

                    if (d6Player > d6Inimigo)
                    {
                        lautrecHumanoInimigo.vida -= 10;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Boa, consegui acertar.");
                        Console.ResetColor();
                    }
                    else if (d6Player < d6Inimigo)
                    {
                        personagemPrincipal.vida -= 10;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eita, essa doeu!");
                        Console.ResetColor();

                        Console.WriteLine("Deseja tentar fugir? [s/n]");
                        string fuga = Console.ReadLine();

                        if (fuga == "s")
                        {
                            int d6fuga = random.Next(1, 6);
                            if (d6fuga <= 3)
                            {
                                Console.WriteLine("Você tentou fugir, mas falhou! A luta continua...");
                            }
                            else
                            {
                                Console.WriteLine("Você conseguiu fugir da batalha!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nada aconteceu!");
                    }

                    Console.WriteLine($"Vida do jogador: {personagemPrincipal.vida}");
                    Console.WriteLine($"Vida do inimigo: {lautrecHumanoInimigo.vida}");
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                Console.Clear();
                if (personagemPrincipal.vida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Você perdeu...");
                    Console.ResetColor();
                }
                else if (lautrecHumanoInimigo.vida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você ganhou!!!");
                    Console.ResetColor();
                }

                Console.WriteLine("\n\nApós a batalha, você sente uma presença vindo na sua direção rapidamente...");
                Console.WriteLine("Um novo inimigo se aproxima! É UM PEQUENO GOBLIN MUITO ÁGIL COM UMA FACA!!!");

                Console.Clear();
                Ficha goblinJareInimigo = new Ficha()
                {
                    nomeDoJogador = "NPC",
                    nomeDoPersonagem = "Jare",
                    raca = "Goblin",
                    classe = "Ladrão",
                    vida = 50
                };

                goblinJareInimigo.imprimirFicha();
                Console.WriteLine("\n");

                while (goblinJareInimigo.vida > 0 && personagemPrincipal.vida > 0)
                {
                    d6Player = random.Next(1, 6);
                    d6Inimigo = random.Next(1, 6);

                    if (d6Player > d6Inimigo)
                    {
                        goblinJareInimigo.vida -= 10;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Boa, consegui acertar!");
                        Console.ResetColor();
                    }
                    else if (d6Player < d6Inimigo)
                    {
                        personagemPrincipal.vida -= 15;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Essa doeu mais!");
                        Console.ResetColor();

                        Console.WriteLine("Deseja tentar fugir? [s/n]");
                        string respostaFuga = Console.ReadLine().ToLower();

                        if (respostaFuga == "s")
                        {
                            int tentativaFuga = random.Next(1, 6);
                            if (tentativaFuga <= 3)
                            {
                                Console.WriteLine("Você conseguiu fugir da batalha!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Você tentou fugir, mas falhou! A luta continua...");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nada aconteceu!");
                    }

                    Console.WriteLine($"Vida do jogador: {personagemPrincipal.vida}");
                    Console.WriteLine($"Vida do inimigo: {goblinJareInimigo.vida}");
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                if (personagemPrincipal.vida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Você perdeu a segunda batalha...");
                    Console.ResetColor();
                }
                else if (goblinJareInimigo.vida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você venceu a segunda batalha!!!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("Você continua a beber.");
            }
        }
    }
}