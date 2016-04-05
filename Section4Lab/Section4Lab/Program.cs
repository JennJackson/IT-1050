namespace Section4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASK FOR MATINEE OR EVENING. IF STATEMENT FOR EITHER
            // WITHIN MATINEE OR EVENING SHOW TICKET PRICES
            // THEN ASK TICKET AGE/AMOUNT


            int adultTicketCount = 0;
            int childTicketCount = 0;
            int seniorTicketCount = 0;
            int ticketCount = adultTicketCount + childTicketCount + seniorTicketCount;

            System.Console.WriteLine("Will you be purchasing matinee or evening tickets?");
            System.Console.WriteLine("Enter [1] for Matinee or [2] for Evening.");
            System.Console.Write("---> ");
            string ticketType = System.Console.ReadLine();
            int inputInteger = int.Parse(ticketType);

            if (inputInteger == 1)
            {
                // Matinee
                // LIST PRICES FOR MATINEE

                double adultMatinee = 5.99;
                double childMatinee = 3.99;
                double seniorMatinee = 4.50;

                System.Console.WriteLine("How many adult tickets would you like to buy?");
                adultTicketCount += int.Parse(System.Console.ReadLine());
                double adultMatineeTotal = adultMatinee * adultTicketCount;

                System.Console.WriteLine("How many children tickets would you like to buy?");
                childTicketCount += int.Parse(System.Console.ReadLine());
                double childMatineeTotal = childMatinee * childTicketCount;

                System.Console.WriteLine("How many senior tickets would you like to buy?");
                seniorTicketCount += int.Parse(System.Console.ReadLine());
                double seniorMatineeTotal = seniorMatinee * seniorTicketCount;


            }
            else if (inputInteger == 2)
            {
                // Evening
                // LIST PRICES FOR EVENING

                double adultEvening = 10.99;
                double childEvening = 6.99;
                double seniorEvening = 8.50;

                System.Console.WriteLine("How many adult tickets would you like to buy?");
                adultTicketCount += int.Parse(System.Console.ReadLine());
                double adultEveningTotal = adultEvening * adultTicketCount;

                System.Console.WriteLine("How many children tickets would you like to buy?");
                childTicketCount += int.Parse(System.Console.ReadLine());
                double childEveningTotal = childEvening * childTicketCount;

                System.Console.WriteLine("How many senior tickets would you like to buy?");
                seniorTicketCount += int.Parse(System.Console.ReadLine());
                double seniorEveningTotal = seniorEvening * seniorTicketCount;
            }   
            else
            {
                System.Console.WriteLine("Input invalid. Please enter 1 or 2.");
                // WHILE LOOP?
            }

            System.Console.ReadKey();

        }
    }
}
