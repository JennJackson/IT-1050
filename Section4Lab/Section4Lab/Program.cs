namespace Section4Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Program purpose:
            // Take user input for types/amounts of tickets based on time & age range.
            // Take user input for whether they want concessions and what kinds/amounts
            // Determines discounts based on certain types/amounts of tickets and concessions purchased
            // Prints out discounts and order price total.

            // *Improve w/ enums & lists*

            Order.GetTicketOrder();
            Order.GetConcessionsOrder();


            double finalPrice = Order.concessionPriceTotal + Order.ticketPriceTotal;

            System.Console.WriteLine("+--------------------------------+");
            System.Console.WriteLine(" Tickets purchased: " + Order.ticketCount);
            System.Console.WriteLine("+--------------------------------+");
            System.Console.WriteLine(" Concessions Purchased: " + Order.concessionCount);
            System.Console.WriteLine(" Free popcorn earned: " + Order.freePopcornCount);
            System.Console.WriteLine(" Free candy earned: " + Order.freeCandyCount);

            System.Console.WriteLine("+--------------------------------+");
            System.Console.WriteLine(" Discount earned on tickets: $" + Order.ticketDiscountTotal);
            System.Console.WriteLine(" Ticket Total: $" + Order.ticketPriceTotal);
            System.Console.WriteLine(" Concessions Total: $" + Order.concessionPriceTotal);
            System.Console.WriteLine("+================================+");
            System.Console.WriteLine(" Final Total: $" + finalPrice);

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }

    }
}
