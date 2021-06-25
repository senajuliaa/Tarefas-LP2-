using System;
using System.Collections.Generic;
using Aula14;

namespace Aula14
{
    public class Compra
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
                // somatorio de valor total de cada item multiplicado pela quantidade de itens no Compra
                foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
                    somatorio += parOrdenado.Key.CalculaValorTotal() * parOrdenado.Value;

                return somatorio;
            }
        }

        public Compra()
        {
            this._itens = new Dictionary<Produto, int>();
        }

        public void ComprarItem(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
            {
                if  (quantidade !> this._itens[item])
                {
                    this._itens[item] = this._itens[item] - quantidade;
                }
                else
                {
                    Console.WriteLine("Estoque insuficiente. Compra cancelada.");
                }
            }
        }

        public void AdicionarItem(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
            { 
                this._itens[item] = this._itens[item] + quantidade;
            }
            else
            { 
                this._itens[item] = quantidade;
            }
        }

        public void AdicionarItem(Produto item)
        {
            this.AdicionarItem(item, 1);
        }

        public void AdicionarItem(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.AdicionarItem(item);
            }
        }

        public void AdicionarItem(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in itens)
            {
                this.AdicionarItem(parOrdenado.Key, parOrdenado.Value);
            }
        }

        public void ImprimirCompra()
        {
            Console.Clear();
            Console.WriteLine("======== Compra ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
                Console.WriteLine("==========================");
            }
            Console.WriteLine("Total do Compra:\tR$ {0:0.00}", this.Total);
            Console.WriteLine("");
            Console.WriteLine("Tecle <enter> para continuar");
            Console.ReadLine();
        }
    }
}