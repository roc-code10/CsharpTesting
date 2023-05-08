namespace Homework6
{
    public class TicketWorker : Worker
    {
        public TicketWorker(string name) : base(name)
        {
        }

        int TicketsSold { get; set; }
        public void SellTickets() 
        { 
            TicketsSold = 0;

            while (true)
            {
                WriteLine("Do you want a ticket? (y/n)");
                string response = ReadLine().ToLower();

                if (response == "y")
                {
                    TicketsSold++;
                }
                else if (response == "n" && TicketsSold == 0)
                {
                    WriteLine("You haven't purchased any tickets, can't visit Zoo");
                    WriteLine("--------------------------------------------------");
                    break;
                }
                else if (response == "n")
                {
                    break;
                }
                else
                {
                    WriteLine("Invalid response, please enter 'y' or 'n'");
                }
            }
            if (TicketsSold > 0)
            {
                WriteLine($"Here are your {TicketsSold} ticket/s sold by {Name}. Welcome to Zoo!");
                WriteLine("------------------------------------------------------");
            }
        }
    }
}
