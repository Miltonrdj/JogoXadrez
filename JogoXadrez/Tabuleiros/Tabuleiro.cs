using System;
using JogoXadrez.Exceptions;

namespace JogoXadrez.Tabuleiros
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }

        public Peca ExibirPeca(int linha, int coluna)
        {
            return pecas[linha,coluna];
        }

        public Peca ExibirPeca(Posicao pos)
        {
            return pecas[pos.Linha,pos.Coluna];
        }

        public bool ExistePeça(Posicao pos)
        {
            ValidarPosicao(pos);
            return ExibirPeca(pos) != null;

        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if(ExistePeça(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posicao !");
            }
            pecas[pos.Linha,pos.Coluna] = p;
            p.Posicao = pos;

        }

        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 ||pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if(!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida !");
            }
        }
    }
}