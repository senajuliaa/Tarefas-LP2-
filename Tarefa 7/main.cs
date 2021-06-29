using System;
using System.Collections.Generic;

class MainClass {

  public static void Cadastrar(){
    Console.Clear();
    Console.WriteLine("\n\nCadastro de Produto");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Preço: ");
    double preco = Convert.ToDouble(Console.ReadLine());
    Produto p = new Produto(nome, preco);
    p.Persistir();
  }

  public static void Listar()
  {
    Console.Clear();
    Console.WriteLine("\n");
    Console.WriteLine("Produtos cadastrados:");
    List<Produto> produtos = Produto.ConsultarProdutos();
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
    Console.WriteLine("");
    Console.WriteLine("<<< Enter para retornar >>>");
    Console.ReadLine();  
  }

  public static void Pesquisar()
  {  
    Console.Clear();
    Console.WriteLine("Qual produto deseja pesquisar? ");
    string pesquisa = Console.ReadLine();
 
    Console.WriteLine("");
    Console.WriteLine("Produtos encontrados: {0}", pesquisa);
    List<Produto> produtos = Produto.PesquisarProdutos(pesquisa);
    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
    Console.WriteLine("");
    Console.WriteLine("<<< Enter para retornar >>>");
    Console.ReadLine();  
  }

  public static void Menu(){
    char opcao;
    do {
      Console.Clear();
      Console.WriteLine("\nOpções: [C]adastrar / [L]istar / [P]esquisar / [S]air");
      opcao = Char.ToLower(Console.ReadKey().KeyChar);
      switch (opcao)
      {
        case 'c':
          Cadastrar();
          break;

        case 'l':
          Listar();
          break;

        case 'p':
          Pesquisar();
          break;

        case 's':
          break;

        default:
          Console.WriteLine("Opção Inválida!");
          break;
      } 
    } while (opcao != 's');
  }
  public static void Main (string[] args) {
    Console.WriteLine("Seja bem vindo ao cadastro de produtos!\n");
    Menu();
    Console.WriteLine("\nAté breve!");
  }
}