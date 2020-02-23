using Xadrez_Console.tabuleiro;
namespace Xadrez_Console.xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[, ] movimentosPossiveis()
        {
            bool[, ] mat = new bool[tab.linhas, tab.colunas];
            return mat;
        }
        public override string ToString()
        {
            return "Q";
        }
    }
}