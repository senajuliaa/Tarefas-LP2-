using System;
using System.Collections.Generic;

namespace Tarefa_03
{
    public class ItensMagicos
    {
        public int Id;
        public string Nome;
        public int Preco;
        public string Categoria;
        public string Descricao;
        public ItensMagicos()
        {
        }
        public ItensMagicos(int id, string nome, int preco, string categoria, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Categoria = categoria;
            this.Descricao = descricao;
        }
    }
    public class Personagens
    {
        public int Id;
        public string Nome;
        public int Saldo;
        public List<Inventario> itens = new List<Inventario>();
        public Personagens()
        {
        }
        public Personagens(int id, string nome, int saldo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Saldo = saldo;
        }
    }
    public class Inventario
    {
        public int Id;
        public string Nome;
        public int Preco;
    }

    public class Program
    {
        static List<ItensMagicos> itensM;
        static List<Personagens> pers;

        static void Main(string[] args)
        {
            itensM = new List<ItensMagicos>();
            itensM.Add(new ItensMagicos(01, "Espada de Ferro", 0010, "Itens de Batalha", "Espada para iniciantes"));
            itensM.Add(new ItensMagicos(02, "Varinha Turbo", 0120, "Itens de Batalha", "Varinha mágica para feiticeiros"));
            itensM.Add(new ItensMagicos(03, "Anel da Invisibilidade", 0500, "Itens de Batalha", "Ao colocá-lo o jogador fica invisível"));
            itensM.Add(new ItensMagicos(11, "Poções", 0050, "Livros Mágicos  ", "Livro com receita de poções"));
            itensM.Add(new ItensMagicos(12, "Feitiços", 0025, "Livros Mágicos  ", "Livro para feiticeiros"));
            itensM.Add(new ItensMagicos(21, "Armadura de Ferro", 0080, "Roupas Mágicas  ", "Armadura padrão para cavaleiros"));
            itensM.Add(new ItensMagicos(22, "Anel de Proteção", 0400, "Roupas Mágicas  ", "Anel que protege o jogador de ataques por  tempo determinado"));
            itensM.Add(new ItensMagicos(23, "Máscara de Caveira", 0010, "Roupas Mágicas  ", "Acessório medieval"));
            itensM.Add(new ItensMagicos(31, "Baratas Voadoras", 0050, "Animais Mágicos ", "Baratas venusianas para atacar o inimigo"));
            itensM.Add(new ItensMagicos(32, "Dragão Northon", 1000, "Animais Mágicos ", "O dragão voa e cospe fogo e é amigo do Sreck"));
            itensM.Add(new ItensMagicos(33, "Macaquinho Perneta", 0015, "Animais Mágicos ", "É super desastrado mas um amigo leal"));

            pers = new List<Personagens>();
            pers.Add(new Personagens(01, "Caçadora Implacável", 1000));
            pers.Add(new Personagens(03, "Feiticeiro Stuart", 1200));
            pers.Add(new Personagens(05, "Guerreira Valquíria", 15000));
            pers.Add(new Personagens(07, "Cavaleiro Escarlate", 5000));


            string opcao = "";
            while (opcao != "0")
            {
                string opcaoExiste = "";

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1 - Consultar meu inventário e saldo");
                Console.WriteLine("2 - Consultar catálogo");
                Console.WriteLine("3 - Comprar");
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("------------");
                Console.Write("Selecione uma opção: ");
                opcao = Console.ReadLine();
                Console.WriteLine();

                if (opcao == "1")
                {
                    Console.Write("informe o nome do seu personagem: ");
                    var nomePersonagem = Console.ReadLine();
                    foreach (Personagens p in pers)
                    {
                        if (p.Nome == nomePersonagem)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine(p.Nome + " | Saldo: " + p.Saldo + " Kalis");
                            Console.WriteLine("");
                            for (int i = 0; i < p.itens.Count; i++)
                            {
                                Console.WriteLine("Item: " + p.itens[i].Nome);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("<<< Digite enter para retornar ao menu >>>");
                            Console.ReadLine();
                            opcaoExiste = "s";
                        }
                    }
                    if (opcaoExiste != "s")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Personagem sem permissão de acesso ou inexistente.");
                        Console.WriteLine("");
                        Console.WriteLine("<<< Digite enter para retornar ao menu >>>");
                        Console.ReadLine();
                    }
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Catálogo de Itens:");
                    Console.WriteLine("");
                    foreach (ItensMagicos p in itensM)
                    {
                        Console.WriteLine(p.Categoria + " | " + p.Nome + " | " + p.Descricao + " | " + p.Preco + " Kalis");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("<<< Digite enter para retornar ao menu >>>");
                    Console.ReadLine();
                }
                if (opcao == "3")
                {
                    int saldo = 0;
                    int preco = 0;
                    string itemComprado = "";

                    Console.Write("informe o nome do seu personagem: ");
                    var nomePersonagem = Console.ReadLine();
                    foreach (Personagens p in pers)
                    {
                        if (p.Nome == nomePersonagem)
                        {
                            saldo = p.Saldo;
                            opcaoExiste = "s";
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine(p.Nome + " | Saldo: " + p.Saldo + " Kalis");
                            Console.WriteLine("");
                        }
                    }
                    if (opcaoExiste != "s")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Personagem sem permissão de acesso ou inexistente.");
                        Console.WriteLine("");
                        Console.WriteLine("<<< Digite enter para retornar ao menu >>>");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Informe o item que deseja comprar: ");
                        var nomeItem = Console.ReadLine();
                        foreach (ItensMagicos p in itensM)
                        {
                            if (p.Nome == nomeItem)
                            {
                                opcaoExiste = "s";
                                Console.WriteLine("");
                                Console.Write("Confirma a compra do item: " + p.Nome + " por " + p.Preco + " Kalis? (Digite S para confirmar) ");
                                var confirma = Console.ReadLine();
                                if (confirma == "S")
                                {
                                    if (saldo >= p.Preco)
                                    {
                                        preco = p.Preco;
                                        itemComprado = p.Nome;
                                        foreach (Personagens q in pers)
                                        {
                                            if (p.Nome == nomePersonagem)
                                            {
                                                saldo = q.Saldo - preco;
                                                //q.itens.Add(itemComprado);
                                                Console.WriteLine("");
                                                Console.WriteLine("Compra efetuada com sucesso. Item adicionado ao seu inventário. Obrigado!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Infelizmente a compra foi negada. Saldo insuficiente.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Compra não confirmada.");
                                }
                            }
                        }
                        if (opcaoExiste != "s")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Item esgotado ou inexistente.");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("<<< Digite enter para retornar ao menu >>>");
                        Console.ReadLine();
                    }
                }
            }
            if (opcao == "0")
            {
                Console.Clear();
                Console.Write("");
                Console.Write("Obrigada por nos visitar. Volte sempre.");
                Console.ReadLine();
            }
        }
    }
}
