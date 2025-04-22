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
                Console.WriteLine("Nome do jogador:    " + nomeDoJogador);
                Console.WriteLine("Nome do personagem: " + nomeDoPersonagem);
                Console.WriteLine("Raça: " + raca);
                Console.WriteLine("Classe: " + classe);
                Console.WriteLine("Vida: " + vida);
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int d6Player;
            int d6Inimigo;
            Ficha personagemPrincipal = new Ficha();

            Console.WriteLine("Digite o nome do jogador: ");
            personagemPrincipal.nomeDoJogador = Console.ReadLine();

            Console.WriteLine("Digite o nome do personagem");
            personagemPrincipal.nomeDoPersonagem = Console.ReadLine();

            Console.WriteLine("Digite a raça do personagem");
            personagemPrincipal.raca = Console.ReadLine();

            Console.WriteLine("Digite a classe do personagem");
            personagemPrincipal.classe = Console.ReadLine();

            personagemPrincipal.vida = 100;

            personagemPrincipal.imprimirFicha();

            Console.WriteLine("\n======AVENTURA COMEÇA======");
            Console.WriteLine("Você esta bebendo em uma taverna");
            Console.WriteLine("Uma pessoa esbarra em você. O que você faz?\n[ 1 ] se vira \n[ 2 ] continua como se nada fosse");

            string decisao = Console.ReadLine();

            if (decisao == "1")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Agora começa a treta !");
                Ficha inimigo = new Ficha();
                inimigo.nomeDoJogador = "NPC";
                inimigo.nomeDoPersonagem = "Lautrec";
                inimigo.raca = "Humano";
                inimigo.classe = "Clérigo";
                inimigo.vida = 80;
                inimigo.imprimirFicha();
                Console.WriteLine("\n");

                while (inimigo.vida > 0 && personagemPrincipal.vida > 0)
                {
                    d6Player = random.Next(1, 6);
                    d6Inimigo = random.Next(1, 6);

                    if (d6Player > d6Inimigo)
                    {
                        inimigo.vida -= 15;
                        Console.WriteLine("Boa, consegui acertar");
                    }
                    else if (d6Player < d6Inimigo)
                    {
                        personagemPrincipal.vida -= 15;
                        Console.WriteLine("Eita, essa doeu!");
                        Console.WriteLine("Deseja tentar fugir? [s/n]");
                        string fuga = Console.ReadLine();

                        if (fuga == "s")
                        {
                            int d6fuga = random.Next(1, 6);
                            if (d6fuga <= 3)
                            {
                                Console.WriteLine("Você tentou fugir mas falhou! A luta continua...");
                            }
                            else
                            {
                                Console.WriteLine("Você conseguio fugir da batalha!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nada aconteceu!");
                    }

                    Console.WriteLine($"Vida do jogador: {personagemPrincipal.vida}");
                    Console.WriteLine($"Vida do inimigo: {inimigo.vida}");
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }
                if (personagemPrincipal.vida <= 0)
                {
                    Console.WriteLine("Você perdeu...");
                }
                else if (inimigo.vida <= 0)
                {
                    Console.WriteLine("Você ganhou!!!");
                }

                Console.WriteLine("\n\nApós a batalha, você sente uma presença vindo na sua direção rapidamente...");
                Console.WriteLine("Um novo inimigo se aproxima! É UM PEQUENO GOBLIN MUITO RÁPIDO");

                Ficha novoInimigo = new Ficha();
                novoInimigo.nomeDoJogador = "NPC";
                novoInimigo.nomeDoPersonagem = "Jare";
                novoInimigo.raca = "Goblin";
                novoInimigo.classe = "Ladrão";
                novoInimigo.vida = 50;  
                novoInimigo.imprimirFicha();
                Console.WriteLine("\n");

                while (novoInimigo.vida > 0 && personagemPrincipal.vida > 0)
                {
                    d6Player = random.Next(1, 6);
                    d6Inimigo = random.Next(1, 6);

                    if (d6Player > d6Inimigo)
                    {
                        novoInimigo.vida -= 10;
                        Console.WriteLine("Boa, consegui acertar!");
                    }
                    else if (d6Player < d6Inimigo)
                    {
                        personagemPrincipal.vida -= 10;
                        Console.WriteLine("Essa doeu mais!");

                        Console.WriteLine("Deseja tentar fugir? [s/n]");
                        string respostaFuga = Console.ReadLine().ToLower();

                        if (respostaFuga == "s")
                        {
                            int tentativaFuga = random.Next(0, 6);
                            if (tentativaFuga <= 2)
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
                    Console.WriteLine($"Vida do inimigo: {novoInimigo.vida}");
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                if (personagemPrincipal.vida <= 0)
                {
                    Console.WriteLine("Você perdeu a segunda batalha...");
                }
                else if (novoInimigo.vida <= 0)
                {
                    Console.WriteLine("Você venceu a segunda batalha!!!");
                }
            }
            else
            {
                Console.WriteLine("Você continua a beber");
            }
        }
    }
}