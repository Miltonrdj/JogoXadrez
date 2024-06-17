using System;
using JogoXadrez.Tabuleiros;

namespace JogoXadrez.Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor corPeca, Tabuleiro tab) : base(corPeca, tab)
        {
            
        }

        public override string ToString()
        {
            return "T";
        }
    }
}