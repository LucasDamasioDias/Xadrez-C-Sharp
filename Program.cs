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
    Console.Write("Destino: ");
    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
    partida.executarMovimento(origem, destino);
}


Tela.imprimirTabuleiro(partida.tab);

Console.ReadLine();