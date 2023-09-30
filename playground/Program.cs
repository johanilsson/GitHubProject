using playground;


Player p1 = new Player();
Player p2 = new Player();

Console.Write("name player 1: ");
p1.name = Console.ReadLine();

Console.WriteLine(--------------);

Console.Write("name player 2: ");
p2.name = Console.ReadLine();

int rnd = new Random().Next(1, 10);
if (rnd % 2 == 0)
{
    p1.firstmove = true;
}
else
{
    p2.firstmove = true;
}


if (p1.firstmove = true)
{

}





void turn()
{



}