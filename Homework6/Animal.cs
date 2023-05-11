namespace Homework6
{
    public class Animal
    {
        public Animal(string name, string food)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if(string.IsNullOrWhiteSpace(food))
                throw new ArgumentNullException(nameof(food));

            Name = name;
            Food = food;
        }

        public string Name { get; set; }
        public string Food { get; set; }
        public bool IsFed { get; set; }

        public string IsAnimalFed()
        {
            if (IsFed)
            {
                return $"{Name} was fed and it ate {Food}";
            }
            else
            {
                return $"{Name} is hungry, it needs to eat some {Food}";
            }
        }
    }
}
