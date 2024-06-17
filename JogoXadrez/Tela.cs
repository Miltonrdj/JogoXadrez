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
                Console.Write(8 - i + " ");
                for(int j = 0;j < tab.Colunas;j++)
                {
                   if (tab.ExibirPeca(i,j)  ==  null)
                   {
                    Console.Write("- ");
                   }
                   else
                   {
                     ImprimirPeça(tab.ExibirPeca(i,j));
                     Console.Write(" ");
                   }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeça(Peca peca)
        {
            if(peca.Cor == Cor.BRANCO)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}