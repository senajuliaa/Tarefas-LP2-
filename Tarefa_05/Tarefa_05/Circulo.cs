using System;

namespace Tarefa_05
{
    public class Circulo : Figura
    {
        private double _raio; // atributo
        public double Raio // propriedade
        {
            // leitura do atributo correspondente
            get
            {
                return this._raio;
            }

            // escrita do atributo correspondente
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Raio inválido");
                }
                else
                {
                    this._raio = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Circulo(double raio)
        {
            // escrita utilizando método set da propriedade
            this.Raio = raio;
        }
        private void AtualizarArea()
        {
            this._area = Math.PI * this._raio * this._raio;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2 * Math.PI * this._raio;
        }
    }
}