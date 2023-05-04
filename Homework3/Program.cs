using Homework3;

Console.WriteLine("Homework3 - Play with objects");

var soldier1 = new Soldier("Soldier1", 30);
var soldier2 = new Soldier("Soldier2", 31);
//Console.WriteLine("Soldiers are shooting");
//soldier1.Shooting(soldier1);
//soldier1.Shooting(soldier2);

var bigBadSoldier1 = new BigBadSoldier("bigBadSoldier1", 45);
Console.WriteLine($"{bigBadSoldier1.Name} is shooting soldiers");
bigBadSoldier1.Shooting(soldier1, GenerateRandomNumber());





//generate random number betwen 0 and 100
static int GenerateRandomNumber()
{
    Random random = new Random();
    return random.Next(45);
}