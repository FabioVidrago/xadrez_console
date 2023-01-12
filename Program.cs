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

                PartidaDeXadrez partida = new PartidaDeXadrez();

                


                Tela.imprimirTabuleiro(partida.tab);

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
