using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei (Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base (tab, cor)
        {
            this.partida = partida;
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool testeRoque(Posicao pos)
        {
            Peca p = tab.peca (pos);
            return p != null && p is Torre && p.cor == cor && p.qteMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0,0);            

            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha - 1, posicao.coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            if(qteMovimentos == 0 && !partida.xeque)
            {
                Posicao T1 = new Posicao(pos.linha, pos.coluna + 3);
                if (testeRoque(T1))
                {
                    Posicao p1 = new Posicao(pos.linha, pos.coluna + 1);
                    Posicao p2 = new Posicao(pos.linha, pos.coluna + 2);
                    if(tab.peca(p1) == null && tab.peca(p2) == null)
                    {
                        mat[pos.linha, pos.coluna + 2] = true;
                    }
                }

                Posicao T2 = new Posicao(pos.linha, pos.coluna - 4);
                if (testeRoque(T2))
                {
                    Posicao p1 = new Posicao(pos.linha, pos.coluna - 1);
                    Posicao p2 = new Posicao(pos.linha, pos.coluna - 2);
                    Posicao p3 = new Posicao(pos.linha, pos.coluna - 3);
                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                    {
                        mat[pos.linha, pos.coluna - 2] = true;
                    }
                }
            }            
            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
