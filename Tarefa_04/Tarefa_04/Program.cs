using System;
using System.Collections.Generic;

namespace Tarefa_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa itens e personagens
            Item espada = new Item(01, "Espada de Ferro", 0010, "Itens de Batalha", "Espada para iniciantes");
            Item varinha = new Item(02, "Varinha Turbo", 0120, "Itens de Batalha", "Varinha mágica para feiticeiros");
            Item anel = new Item(03, "Anel da Invisibilidade", 0500, "Itens de Batalha", "Ao colocá-lo o jogador fica invisível");
            Item mascara = new Item(11, "Máscara de Caveira", 0010, "Roupas Mágicas  ", "Acessório medieval");
            Item barata = new Item(21, "Baratas Voadoras", 0050, "Animais Mágicos ", "Baratas venusianas para atacar o inimigo");
            Item dragao = new Item(22, "Dragão Northon", 1000, "Animais Mágicos ", "O dragão voa e cospe fogo e é amigo do Sreck");

            Personagem princesa = new Personagem(01, "Princesa Implacável", 1000);
            Personagem feiticeiro = new Personagem(03, "Feiticeiro Stuart", 1200);
            Personagem guerreira = new Personagem(05, "Guerreira Valquíria", 15000);
            Personagem cavaleiro = new Personagem(07, "Cavaleiro Escarlate", 5000);

            // executa doação inicial de um item para cada personagem
            princesa.PegarItem(espada);
            feiticeiro.PegarItem(varinha);
            guerreira.PegarItem(barata);
            cavaleiro.PegarItem(mascara);

            // exibe menu principal
            string opcao = "";
            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1 - Exibir personagens");
                Console.WriteLine("2 - Exibir catálogo");
                Console.WriteLine("3 - Comprar");
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("------------");
                Console.Write("Selecione uma opção: ");
                opcao = Console.ReadLine();
                Console.WriteLine();

                if (opcao == "0")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Obrigado por nos visitar. Volte sempre.");
                    Console.ReadLine();
                }
                else if  (opcao == "1")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Personagens:");
                    princesa.ExibirPersonagem();
                    feiticeiro.ExibirPersonagem();
                    guerreira.ExibirPersonagem();
                    cavaleiro.ExibirPersonagem();                 
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Itens Mágicos:");
                    espada.ExibirItem();
                    varinha.ExibirItem();
                    anel.ExibirItem();
                    mascara.ExibirItem();
                    barata.ExibirItem();
                    dragao.ExibirItem();
                }
                else if (opcao == "3")
                {
                    Console.Write("informe o nome do seu personagem: ");
                    var nomePersonagem = Console.ReadLine();
                    var nomesP = new List<string>() { "Princesa Implacável", "Feiticeiro Stuart", "Guerreira Valquíria", "Cavaleiro Escarlate" };

                    string existePers = "";
                    foreach (string nome in nomesP)
                    {
                        if (nome == nomePersonagem)
                        {
                            existePers = "s";
                        }
                    }
                    if (existePers != "s")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Personagem sem permissão de acesso ou inexistente.");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Informe o item que deseja comprar: ");
                        var nomeItem = Console.ReadLine();
                        var nomesI = new List<string>() { "Espada de Ferro", "Varinha Turbo", "Anel da Invisibilidade", "Máscara de Caveira", "Baratas Voadoras", "Dragão Northon" };

                        string existeItem = "";
                        foreach (string nome in nomesI)
                        {
                            if (nome == nomeItem)
                            {
                                existeItem = "s";
                                princesa.ComprarItem(espada);
                            }
                        }
                        if (existeItem != "s")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Item esgotado ou inexistente.");
                        }
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("<<< Digite enter para retornar >>>");
                Console.ReadLine();
            }
        }
    }
}


