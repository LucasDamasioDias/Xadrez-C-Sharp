using tabuleiro;
using xadrez;
using Xadrez;

Tabuleiro tab = new Tabuleiro(8,8);


tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));

Tela.imprimirTabuleiro(tab);

Console.ReadLine();