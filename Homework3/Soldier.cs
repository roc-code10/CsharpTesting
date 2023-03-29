using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Soldier : Person
    {
        public Soldier(string name, int age) : base(name, age)
        {
        }

        public void Shooting(Soldier enemy)
        {
            var randomNumber = GenerateRandomNumber();
            enemy.Health -= randomNumber;
            
            if (enemy.Health > 0)
            {
                Console.WriteLine($"Health of soldier {enemy.Name} is {enemy.Health}, got lucky, still alive");
            }
            else if (enemy.Health <= 0) 
            {
                Console.WriteLine($"Health of soldier {enemy.Name} is {enemy.Health}, headshot, dead");
            }
        }

        //generate random number betwen 0 and 100
        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(101);
        }
    }
}
