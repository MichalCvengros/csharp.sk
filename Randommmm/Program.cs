using Randommmm;

string playerName = Console.ReadLine();


player player = new player();
player.SetName(playerName);

Monster monster = new Monster();

player.DealDamage(monster);
monster.DealDamage(player);

Console.WriteLine();

