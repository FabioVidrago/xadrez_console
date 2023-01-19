using tabuleiro;

namespace xadrez
{
    class Rei :Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        
        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        } 
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima 
            pos.defenirValores(posicao.linha - 1, posicao.coluna);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //nordeste 
            pos.defenirValores(posicao.linha - 1, posicao.coluna+1);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //direita 
            pos.defenirValores(posicao.linha, posicao.coluna+1);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //sudeste
            pos.defenirValores(posicao.linha +1, posicao.coluna + 1);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //baixo
            pos.defenirValores(posicao.linha + 1, posicao.coluna);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //sudoeste
            pos.defenirValores(posicao.linha + 1, posicao.coluna - 1);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda
            pos.defenirValores(posicao.linha, posicao.coluna - 1);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Noroeste
            pos.defenirValores(posicao.linha - 1, posicao.coluna - 1);
            if (!tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
