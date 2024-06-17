using System;
using JogoXadrez.Tabuleiros;

namespace JogoXadrez
{
    class Tela
    {
        public static void ExibirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas;i++)
            {
                for(int j = 0;j < tab.Colunas;j++)
                {
                   if (tab.ColocarPeca(i,j)  ==  null)
                   {
                    Console.Write("- ");
                   }
                   else
                   {
                     Console.Write(tab.ColocarPeca(i,j) + " ");
                   }
                }
                Console.WriteLine();
            }
        }
    }
}