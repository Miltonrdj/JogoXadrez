using System;
using JogoXadrez.PecasDeXadrez;
using JogoXadrez.Tabuleiros;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro1 = new Tabuleiro(8, 8);
            tabuleiro1.ColocarPeca(new Torre(Cor.PRETO,tabuleiro1),new Posicao(0,0));
            tabuleiro1.ColocarPeca(new Torre(Cor.PRETO,tabuleiro1),new Posicao(1,3));
            tabuleiro1.ColocarPeca(new  Rei(Cor.PRETO,tabuleiro1),new Posicao(2,4));


            Tela.ExibirTabuleiro(tabuleiro1);
        }
    }
}