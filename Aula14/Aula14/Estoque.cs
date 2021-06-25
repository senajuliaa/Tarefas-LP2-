using System;
using System.Collections.Generic;
using Aula14;

namespace Aula14
{
    public class Estoque
    {
        private Dictionary<Produto, int> _itens;

        public Dictionary<Produto, int> Itens
        {
            get { return this._itens; }
        }

        public double Total
        {
            get
            {
                double somatorio = 0;
                // somatorio de valor total de cada item multiplicado pela quantidade de itens no Estoque
                foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
                    somatorio += parOrdenado.Key.CalculaValorTotal() * parOrdenado.Value;

                return somatorio;
            }
        }

        public Estoque()
        {
            this._itens = new Dictionary<Produto, int>();
        }

        public void Adicionar(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
                this._itens[item] = this._itens[item] + quantidade;
            else
                this._itens[item] = quantidade;
        }

        public void Adicionar(Produto item)
        {
            this.Adicionar(item, 1);
        }

        public void Adicionar(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.Adicionar(item);
            }
        }

        public void Adicionar(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in itens)
            {
                this.Adicionar(parOrdenado.Key, parOrdenado.Value);
            }
        }

        public void Remover(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
                this._itens[item] = this._itens[item] - quantidade;
            else
                this._itens[item] = quantidade;
        }

        public void Remover(Produto item)
        {
            this.Remover(item, 1);
        }

        public void Remover(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.Remover(item);
            }
        }

        public void Remover(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in itens)
            {
                this.Remover(parOrdenado.Key, parOrdenado.Value);
            }
        }




        public void ImprimirEstoque()
        {
            Console.WriteLine("======== Estoque ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
                Console.WriteLine("==========================");
            }
            Console.WriteLine("Total do Estoque:\tR$ {0:0.00}", this.Total);
            Console.WriteLine("==========================");
        }
    }
}