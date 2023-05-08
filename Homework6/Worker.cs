namespace Homework6
{
    public class Worker
    {
        public Worker(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
        public string Name { get; set; }
        public List<Animal>? Animals { get; set; }
    }
}
