using System;
using JogoXadrez.Tabuleiros;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro1 = new Tabuleiro(8, 8);

            Tela.ExibirTabuleiro(tabuleiro1);
        }
    }
}