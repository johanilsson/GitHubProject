using RockPaperScissors;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

int playerCount = 2;

List<Player> players = new List<Player>();

for(int i =1; i < playerCount; i ++)
{
    string name = string.Empty;
    while(name.Length == 0)
    {
        Console.Clear();
        Console.WriteLine("Please enter the name of player" + i + ": ");
        name = Console.ReadLine() ?? string.Empty;
    }

    players.Add(new Player(name));
}


for(int round = 1; round <= 3; i++)
{
   foreach(Player plater in players)
    {
        DisplayGameState(round);

        Console.ReadKey();
    }



    Console.ReadKey();
}

void DisplayGameState(int round)
{
    foreach (Player player in players)
    {
        Console.WriteLine(player.Name + " ");
        Console.Clear();
        Console.WriteLine("Round " + round);
        Console.WriteLine("Players in game: ");


    }
}

outcome CalculateOutcome(Player p1, Player p2)
{
    if (p1.choice.Equals(Option.Rock) && p2.Choice.Equals(Option.scissors);

    {
        return outcome.win;

    }
}