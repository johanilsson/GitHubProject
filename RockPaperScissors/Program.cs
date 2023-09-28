using RockPaperScissors;

Random rnd = new Random();
int begin = (rnd.Next(0, 10));
string beginersIs;
string[] choice = { "Rock", "Papper", "Sissor" };
int game;
int index;



Console.Write("Player 1 name: ");
string player1 = Console.ReadLine();
Console.WriteLine("-------------------------");
Console.Write("Player 2 name: ");
string player2 = Console.ReadLine();

Console.Clear();

Console.WriteLine("Welcome " + player1 + " & " + player2);
Console.WriteLine("Lets play a game of Rock Papper Sissors");

Thread.Sleep(3000);

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

// begining

Console.WriteLine(beginersIs + " <- Begins!");

Thread.Sleep(1000);

Console.WriteLine("------------------");

makeChoice();




void makeChoice()
{
   
    for (int i = 0; i < choice.Length; i++)
    {
        Console.WriteLine("[ " + i +  " ]" + choice[i]);

    }
        Console.WriteLine("------------------");
    Console.Write(beginersIs + " make a choice: ");
    game = Convert.ToInt32(Console.ReadLine());
    
}


