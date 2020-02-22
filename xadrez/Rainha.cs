using Xadrez_Console.tabuleiro;
namespace Xadrez_Console.xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString(){
            return "Q";
        }
    }
}