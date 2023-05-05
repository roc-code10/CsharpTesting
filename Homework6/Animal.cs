namespace Homework6
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? Food { get; set; }
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
