using Xadrez_Console.tabuleiro;
namespace Xadrez_Console.xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            this.tab = new Tabuleiro(8, 8);
            this.turno = 1;
            this.jogadorAtual = Cor.Branca;
            this.terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Rainha(tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Rainha(tab, Cor.Branca), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 8).toPosicao());

        }
    }
}