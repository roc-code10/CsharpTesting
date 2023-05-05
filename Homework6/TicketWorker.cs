namespace Homework6
{
    public class TicketWorker : Worker
    {
       int TicketsSold { get; set; }
       public void SellTickets() 
        { 
            TicketsSold = 0;

            while (true)
            {
                Console.WriteLine("Do you want a ticket? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    TicketsSold++;
                }
                else if (response == "n" && TicketsSold == 0)
                {
                    Console.WriteLine("You haven't purchased any tickets, can't visit Zoo");
                    Console.WriteLine("--------------------------------------------------");
                    break;
                }
                else if (response == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response, please enter 'y' or 'n'");
                }
            }
            if (TicketsSold > 0)
            {
                Console.WriteLine($"Here are your {TicketsSold} ticket/s sold by {Name}. Welcome to Zoo!");
                Console.WriteLine("------------------------------------------------------");
            }
        }
    }
}
