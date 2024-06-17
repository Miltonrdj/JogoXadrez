using System;

namespace JogoXadrez.Tabuleiros
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        override public string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }

}