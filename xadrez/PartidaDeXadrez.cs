using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('e', 8).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 1).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 8).ToPosicao());/*
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 8).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 1).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 1).ToPosicao());*/
        }
    }
}
