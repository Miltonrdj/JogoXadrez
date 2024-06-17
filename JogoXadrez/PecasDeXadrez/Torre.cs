using System;
using JogoXadrez.Tabuleiros;

namespace JogoXadrez.PecasDeXadrez
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