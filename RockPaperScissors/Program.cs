Random rnd = new Random();
int begin = (rnd.Next(0, 10));
string beginersIs;

Console.Write("Player 1 name: ");
string player1 = Console.ReadLine();
Console.WriteLine("-------------------------");
Console.Write("Player 2 name: ");
string player2 = Console.ReadLine();

Console.Clear();

Console.WriteLine("Welcome " + player1 + " & " + player2);
Console.WriteLine("Lets play a game of Rock Papper Sissors");


Console.Clear();

// Random 

if(begin % 2 ==0)
    {
    beginersIs = player1;
    }
else
    {
    beginersIs = player2;
    }
Console.WriteLine(begin);
Console.WriteLine(beginersIs + " <- Begins!");