using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Vermelha), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Vermelha), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Amarelo), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));


                Tela.imprimirTabuleiro(tab);

                /*PosicaoXadrez pos = new PosicaoXadrez('c',7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
                */
                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
