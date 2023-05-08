using Homework6;

WriteLine("Welcome to Zoo (^.^)");

var ticketWorker = new TicketWorker("Brian");
ticketWorker.SellTickets();

var workerThatFeedsAnimals = new Worker("Johnny");
workerThatFeedsAnimals.Animals = new List<Animal>();

var Giraffe = new Animal("Giraffe", "Leaves");
Giraffe.IsFed = true;

var Lion = new Animal("Lion", "Meat");
Lion.IsFed = false;

var Panda = new Animal("Panda", "Bamboo");
Panda.IsFed = true;

workerThatFeedsAnimals.Animals.Add(Giraffe);
workerThatFeedsAnimals.Animals.Add(Lion);
workerThatFeedsAnimals.Animals.Add(Panda);

foreach (var animal in workerThatFeedsAnimals.Animals)
{
    WriteLine($"{workerThatFeedsAnimals.Name} takes care of {animal.Name} who's eating {animal.Food} and {animal.IsAnimalFed()}");
}


