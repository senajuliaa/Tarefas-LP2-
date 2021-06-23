using System;
using System.Collections.Generic;

namespace Tarefa_04
{
    public class Personagem
    {
        public int Id;
        public string Nome;
        public int Saldo;
        public List<Item> Inventario;
        public Personagem()
        {
        }
        public Personagem(int id, string nome, int saldo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Inventario = new List<Item>();
        }
        public void ExibirPersonagem()
        {
            Console.WriteLine("");
            Console.WriteLine("Id:\t\t{0}", this.Id);
            Console.WriteLine("Nome:\t\t{0}", this.Nome);
            Console.WriteLine("Saldo:\t\t{0}", this.Saldo);
            Console.Write("Inventário:\t[");
            foreach (var item in Inventario)
            {
                Console.Write("{0}\t", item.Nome);
            }
            Console.WriteLine("]");
        }
        public void PegarItem(Item item)
        {
            this.Inventario.Add(item);
        }
        public void ComprarItem(Item item)
        {
            if (this.Saldo < item.Preco)
            {
                Console.WriteLine("");
                Console.WriteLine("Infelizmente a compra foi negada. Saldo insuficiente.");
            }
            else
            {
                this.Saldo = this.Saldo - item.Preco;
                this.PegarItem(item);
                Console.WriteLine("");
                Console.WriteLine("Compra efetuada com sucesso. Item adicionado ao seu inventário. Obrigado!");
            }
        }
    }
}
