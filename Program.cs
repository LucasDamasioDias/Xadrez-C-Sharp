using tabuleiro;
using xadrez;
using Xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        try
        {
            Console.Clear();
            Tela.imprimirPartida(partida);


            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoOrigem(origem);

            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDestino(origem, destino);

            partida.realizaJogada(origem, destino);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }

    Tela.imprimirTabuleiro(partida.tab);

    Console.ReadLine();
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}