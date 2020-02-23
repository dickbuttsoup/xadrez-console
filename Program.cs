using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 1));
                tab.colocarPeca(new Rainha(tab, Cor.Branca), new Posicao(5, 7));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}