using System;

namespace Tarefa_05
{
    public class Retangulo : Figura
    {
        private double _lados; // atributo
        public double Lados // propriedade
        {
            // leitura do atributo correspondente
            get
            {
                return this._lados;
            }

            // escrita do atributo correspondente
            set
            {
                this._lados = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
        public Retangulo(double lados)
        {
            // escrita utilizando método set da propriedade
            this.Lados = lados;
        }
        private void AtualizarArea()
        {
            this._area = (this._lados/2) * (this._lados/2);
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = this._lados + this._lados;
        }
    }
}