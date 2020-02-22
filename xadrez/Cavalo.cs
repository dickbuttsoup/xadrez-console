using Xadrez_Console.tabuleiro;
namespace Xadrez_Console.xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString(){
            return "C";
        }
    }
}