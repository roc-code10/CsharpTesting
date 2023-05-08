
//Create a system for managing a zoo. You will have the next entities:
//different animals, each one with a name, what they eat and a field that shows if they were fed
//workers that feed the animals
//1 worker that sells tickets for the zoo
//Assign a worker to list of animals that it need to take care for
//Feed the animals.
//Keep track of the number of tickets sold

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


