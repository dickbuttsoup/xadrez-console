using Xadrez_Console.tabuleiro;
namespace Xadrez_Console.xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString(){
            return "P";
        }
    }
}