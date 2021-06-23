using System;

namespace Tarefa_04
{
    public class Item
    {
        public int Id;
        public string Nome;
        public int Preco;
        public string Categoria;
        public string Descricao;
        public Item()
        {
        }
        public Item(int id, string nome, int preco, string categoria, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Categoria = categoria;
            this.Descricao = descricao;
        }
        public void ExibirItem()
        {
            Console.WriteLine("");
            Console.WriteLine("Id:\t\t\t{0}", this.Id);
            Console.WriteLine("Nome:\t\t\t{0}", this.Nome);
            Console.WriteLine("Descrição:\t\t{0}", this.Descricao);
            Console.WriteLine("Categoria:\t\t{0}", this.Categoria);
            Console.WriteLine("Preço(em Kalis):\t{0}", this.Preco);
         }
    }
}
