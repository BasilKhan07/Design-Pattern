using DependencyInjection;

GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gm.PlayRound();

    if (result == RoundResult.Player1Win)
    {
        Console.WriteLine("Player 1 wins!");
    }
    else if (result == RoundResult.Player2Win)
    {
        Console.WriteLine("Player 2 wins!");
    }
    else
    {
        Console.WriteLine("Draw!");
    }
    Console.WriteLine("Play Again (Y/N)? ");
} while (Console.ReadLine().ToUpper() == "Y");