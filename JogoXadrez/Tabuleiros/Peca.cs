using System;


namespace JogoXadrez.Tabuleiros
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public Tabuleiro Tab{ get; protected set; }

        public Peca( Cor corPeca,Tabuleiro tab)
        {
            this.Posicao = null;
            this.Tab = tab;
            this.Cor = corPeca;
            this.QtdMovimento = 0;
        }


    }
}