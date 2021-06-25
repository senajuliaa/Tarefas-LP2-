using System;
using System.Collections.Generic;

namespace Aula14
{
    public class Fornecedor : IImprimivel
    {
        private string _nome;
        private string _cnpj;
        private List<Produto> Produtos;

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public string cnpj
        {
            get
            {
                return this._cnpj;
            }
        }

        public Fornecedor(string nome, string cnpj)
        {
            this._nome = nome;
            this._cnpj = cnpj;
            this.Produtos = new List<Produto>();
        }
        public void AssociarProduto(Produto item)
        {
            this.Produtos.Add(item);
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t\t{0}", this.Nome); 
            Console.WriteLine("CNPJ:\t\t{0}", this.cnpj);
            Console.Write("Produtos:\t[ ");
            foreach (var item in Produtos)
            {
                Console.Write("{0}\t", item.Nome);
            }
            Console.WriteLine("]");
        }
    }
}