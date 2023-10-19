

Mago mago1 = new Mago("Mago1");
Ninja ninja1 = new Ninja("Ninja1");
Samurai samurai1 = new Samurai("Samurai1");

mago1.ShowInfo();
Console.WriteLine("--------------------------");
ninja1.ShowInfo();
Console.WriteLine("--------------------------");
samurai1.ShowInfo();
Console.WriteLine("--------------------------");

mago1.Attack(samurai1);
mago1.ShowInfo();
Console.WriteLine("--------------------------");
samurai1.ShowInfo();
Console.WriteLine("--------------------------");