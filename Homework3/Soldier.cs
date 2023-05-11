namespace Homework3
{
    public class Soldier : Person
    {
        public Soldier(string name, int age) : base(name, age)
        {
        }

        public string Shooting(Soldier enemy, int damage)
        {
            enemy.Health -= damage;
            
            if (enemy.Health > 0)
            {
                return $"Health of soldier {enemy.Name} is {enemy.Health}, got lucky, still alive";
            }
            else 
            {
                return $"Health of soldier {enemy.Name} is {enemy.Health}, headshot, dead";
            }
        }
    }
}
