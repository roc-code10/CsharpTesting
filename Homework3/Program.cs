using Homework3;

Console.WriteLine("Homework3 - Play with objects");

var soldier1 = new Soldier("Soldier1", 30);
var soldier2 = new Soldier("Soldier2", 31);
soldier1.Shooting(soldier1);
soldier1.Shooting(soldier2);