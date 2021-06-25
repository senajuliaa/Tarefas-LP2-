using System;

namespace Aula14
{
    public class ProdutoFisico : Produto
    {

        private double _frete;

        public double Frete
        {
            get { return this._frete; }
        }
        public ProdutoFisico(string nome, double preco, double frete)
        {
            this._nome = nome;
            this._preco = preco;
            this._frete = frete;
        }

        public override double CalculaValorTotal()
        {
            return this._frete + this._preco;
        }
        public override void Imprimir()
        {
            Console.WriteLine("Produto:\t{0}", this.Nome); 
            Console.WriteLine("Preço:\t\tR$ {0:0.00}", this._preco);
            Console.WriteLine("Frete:\t\tR$ {0:0.00}", this._frete);
            Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
        }
    }
}