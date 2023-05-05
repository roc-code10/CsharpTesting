using Homework6;

Console.WriteLine("Welcome to Zoo");

var ticketWorker = new TicketWorker();
ticketWorker.Name = "Brian";
ticketWorker.SellTickets();

var workerThatFeedsAnimals = new Worker();
workerThatFeedsAnimals.Name = "Johnny";
workerThatFeedsAnimals.Animals = new List<Animal>();

var Giraffe = new Animal();
Giraffe.Name = "Giraffe";
Giraffe.Food = "leaves";
Giraffe.IsFed = true;

var Lion = new Animal();
Lion.Name = "Lion";
Lion.Food = "meat";
Lion.IsFed = false;

var Panda = new Animal();
Panda.Name = "Panda";
Panda.Food = "bamboo";
Panda.IsFed = true;

workerThatFeedsAnimals.Animals.Add(Giraffe);
workerThatFeedsAnimals.Animals.Add(Lion);
workerThatFeedsAnimals.Animals.Add(Panda);

foreach (var animal in workerThatFeedsAnimals.Animals)
{
    Console.WriteLine($"{workerThatFeedsAnimals.Name} takes care of {animal.Name} who's eating {animal.Food} and {animal.IsAnimalFed()}");

}


