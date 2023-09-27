Console.Write("Player 1 name: ");
string p1 = Console.ReadLine();
Console.WriteLine("-------------------------");
Console.Write("Player 2 name: ");
string p2 = Console.ReadLine();

Console.Clear();

Console.WriteLine("Welcome " + p1 + " & " + p2);
Console.WriteLine("Lets play a game of Rock Papper Sissors");


Console.Clear();

// Random 

Random rnd = new Random();

int begin = (rnd.Next(0, 10));

Console.WriteLine(begin);