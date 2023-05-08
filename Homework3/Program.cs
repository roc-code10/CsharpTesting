using Homework3;

WriteLine("Play with objects");

WriteLine("Create a program that has a class that represents an object of your choice " +
    "and define its functionalities. \nPlay with it in the Main as your heart wishes to. " +
    "\nAs a challenge you can create children for your object, but it's not mandatory.");

WriteLine("----------------------------------------------------");

var soldier1 = new Soldier("Soldier One", 30);
var soldier2 = new Soldier("Soldier Two", 31);

var bigBadSoldier1 = new BigBadSoldier("Big Bad Soldier", 45);
WriteLine($"{bigBadSoldier1.Name} is shooting {soldier1.Name}");
bigBadSoldier1.Shooting(soldier1, GenerateRandomNumber());
WriteLine($"{soldier1.Name} has health {soldier1.Health}");

WriteLine("********************************************");

WriteLine($"{bigBadSoldier1.Name} is shooting {soldier2.Name}");
bigBadSoldier1.Shooting(soldier2, GenerateRandomNumber());
WriteLine($"{soldier2.Name} has health {soldier2.Health}");

WriteLine("********************************************");

WriteLine($"{soldier1.Name} is shooting {soldier2.Name}");
WriteLine(soldier1.Shooting(soldier2,GenerateRandomNumber()));

//generate random number betwen 0 and 100
static int GenerateRandomNumber()
{
    Random random = new Random();
    return random.Next(45);
}