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
            enemy.Health--;
            Console.WriteLine($"Health of soldier {enemy.Name} is {enemy.Health}");
        }
    }
}
