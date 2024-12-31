using tabuleiro;
using xadrez;
using Xadrez;

PartidaDeXadrez partida = new PartidaDeXadrez();

while (!partida.terminada)
{
    Console.Clear();
    Tela.imprimirTabuleiro(partida.tab);

    Console.Write("Origem: ");
    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

    Console.Clear();
    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

    Console.Write("Destino: ");
    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
    partida.executarMovimento(origem, destino);
}


Tela.imprimirTabuleiro(partida.tab);

Console.ReadLine();