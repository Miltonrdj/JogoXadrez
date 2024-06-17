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
                   if (tab.ExibirPeca(i,j)  ==  null)
                   {
                    Console.Write("- ");
                   }
                   else
                   {
                     Console.Write(tab.ExibirPeca(i,j) + " ");
                   }
                }
                Console.WriteLine();
            }
        }
    }
}