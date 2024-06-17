using System;
using JogoXadrez.Tabuleiros;

namespace JogoXadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei(Cor corPeca, Tabuleiro tab) : base(corPeca, tab)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}