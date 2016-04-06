namespace Section4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASK FOR MATINEE OR EVENING. IF STATEMENT FOR EITHER
            // WITHIN MATINEE OR EVENING SHOW TICKET PRICES
            // THEN ASK TICKET AGE/AMOUNT

            // USE WHILE LOOP FROM OTHER LAB TO ONLY ACCEPT POSITIVE OR SPECIFIED VALUES
            // USE THIS FOR EVERY QUESTION EVERY!!!!!


            int adultTicketCount = 0;
            int childTicketCount = 0;
            int seniorTicketCount = 0;
            int matineeTicketCount = 0;
            int eveningTicketCount = 0;
            int ticketCount = 0;

            double adultMatineePrice = 5.99;
            double childMatineePrice = 3.99;
            double seniorMatineePrice = 4.50;

            double adultEveningPrice = 10.99;
            double childEveningPrice = 6.99;
            double seniorEveningPrice = 8.50;

            double smallSoda = 3.50;
            double largeSoda = 5.99;
            double hotDog = 3.99;
            double popcorn = 4.50;
            double candy = 1.99;

            int smallSodaCount = 0;
            int largeSodaCount = 0;
            int hotDogCount = 0;
            int popcornCount = 0;
            int candyCount = 0;
            int freePopcornCount = 0;
            int freeCandyCount = 0;

            double ticketPriceTotal = 0;

            System.Console.WriteLine("Will you be purchasing matinee or evening tickets?");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter [1] for Matinee or [2] for Evening.");
            System.Console.Write("---> ");
            int ticketType = int.Parse(System.Console.ReadLine());

            /* while (true)
             {
                 ticketType = int.Parse(System.Console.ReadLine());

                 if ()
                 {

                 }
             }
             */
            // while (System.Console.ReadKey(true).Key != System.ConsoleKey.NumPad1 || System.ConsoleKey.NumPad2) { }

            if (ticketType == 1)
            {
                // Matinee
                System.Console.WriteLine();
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine(" Matinee Prices");
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine(" Adult: $" + adultMatineePrice);
                System.Console.WriteLine(" Child: $" + childMatineePrice);
                System.Console.WriteLine(" Senior: $" + seniorMatineePrice);
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine();



                System.Console.WriteLine("How many adult tickets would you like to buy?");
                System.Console.Write("---> ");
                adultTicketCount = int.Parse(System.Console.ReadLine());
                double adultMatineeTotal = adultMatineePrice * adultTicketCount;

                System.Console.WriteLine("How many children tickets would you like to buy?");
                System.Console.Write("---> ");
                childTicketCount = int.Parse(System.Console.ReadLine());
                double childMatineeTotal = childMatineePrice * childTicketCount;

                System.Console.WriteLine("How many senior tickets would you like to buy?");
                System.Console.Write("---> ");
                seniorTicketCount = int.Parse(System.Console.ReadLine());
                double seniorMatineeTotal = seniorMatineePrice * seniorTicketCount;

                matineeTicketCount = adultTicketCount + childTicketCount + seniorTicketCount;
                ticketCount = matineeTicketCount;
                ticketPriceTotal = adultMatineeTotal + childMatineeTotal + seniorMatineeTotal;

            }
            else if (ticketType == 2)
            {
                // Evening
                System.Console.WriteLine();
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine(" Evening Prices");
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine(" Adult: $" + adultEveningPrice);
                System.Console.WriteLine(" Child: $" + childEveningPrice);
                System.Console.WriteLine(" Senior: $" + seniorEveningPrice);
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine(" Specials");
                System.Console.WriteLine("+--------------+");
                System.Console.WriteLine(" - Buy 3 tickets, get 1 bag of popcorn, free!");
                System.Console.WriteLine();


                System.Console.WriteLine("How many adult tickets would you like to buy?");
                System.Console.Write("---> ");
                adultTicketCount = int.Parse(System.Console.ReadLine());
                double adultEveningTotal = adultEveningPrice * adultTicketCount;

                System.Console.WriteLine("How many children tickets would you like to buy?");
                System.Console.Write("---> ");
                childTicketCount = int.Parse(System.Console.ReadLine());
                double childEveningTotal = childEveningPrice * childTicketCount;

                System.Console.WriteLine("How many senior tickets would you like to buy?");
                System.Console.Write("---> ");
                seniorTicketCount = int.Parse(System.Console.ReadLine());
                double seniorEveningTotal = seniorEveningPrice * seniorTicketCount;

                eveningTicketCount = adultTicketCount + childTicketCount + seniorTicketCount;
                ticketCount = eveningTicketCount;
                ticketPriceTotal = adultEveningTotal + childEveningTotal + seniorEveningTotal;

                if (eveningTicketCount >= 3)
                {
                    freePopcornCount++;
                }
            }
            else
            {
                System.Console.WriteLine("Input invalid. Please enter 1 or 2.");
                // WHILE LOOP?
            }


            ///////////////////////////////////////////////////////

            System.Console.WriteLine();
            System.Console.WriteLine("Would you like to purchase any concessions?");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter [1] for Yes or [2] for No.");
            System.Console.Write("---> ");
            int wantsConcessions = int.Parse(System.Console.ReadLine());

            if (wantsConcessions == 1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("+-------------------+");
                System.Console.WriteLine(" Concession Prices");
                System.Console.WriteLine("+-------------------+");
                System.Console.WriteLine(" Small Soda: $" + smallSoda);
                System.Console.WriteLine(" Large Soda: $" + largeSoda);
                System.Console.WriteLine(" Hot Dog: $" + hotDog);
                System.Console.WriteLine(" Popcorn: $" + popcorn);
                System.Console.WriteLine(" Candy: $" + candy);
                System.Console.WriteLine("+-------------------+");
                System.Console.WriteLine(" Specials ");
                System.Console.WriteLine("+-------------------+");
                System.Console.WriteLine(" - Buy popcorn & a large soda, get $2 off your ticket");
                System.Console.WriteLine(" - Buy 3 candies, get 1 free");
                System.Console.WriteLine();

                System.Console.WriteLine("How many small sodas would you like to buy?");
                System.Console.Write("---> ");
                smallSodaCount = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("How many large sodas would you like to buy?");
                System.Console.Write("---> ");
                largeSodaCount = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("How many hot dogs would you like to buy?");
                System.Console.Write("---> ");
                hotDogCount = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("How many bags of popcorn would you like to buy?");
                System.Console.Write("---> ");
                popcornCount = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("How many bags of candy would you like buy?");
                System.Console.Write("---> ");
                candyCount = int.Parse(System.Console.ReadLine());


                //THIS NEEDS TO BE CALLED BEFORE THE FREE POPCORN IF STATEMENT

                while (popcornCount >= 1 && largeSodaCount >= 1 && ticketPriceTotal >= 2)
                {
                    popcornCount--;
                    largeSodaCount--;
                    ticketPriceTotal -= 2;
                }
                                               
                while (candyCount >= 3)
                {
                    freeCandyCount++;
                    candyCount -= 3;
                }
                                                
            }
            else if (wantsConcessions == 2)
            {
                System.Console.WriteLine("No concessions added.");
            }
            else
            {
                System.Console.WriteLine("Your entry is invalid. Please retry.");
                // While Loop.
            }

            System.Console.WriteLine("Adult Tickets: " + adultTicketCount);
            System.Console.WriteLine("Children Tickets: " + childTicketCount);
            System.Console.WriteLine("Senior Tickets: " + seniorTicketCount);

            System.Console.WriteLine("Ticket Amount: " + ticketCount);
            System.Console.WriteLine("Ticket Total: $" + ticketPriceTotal);
            System.Console.ReadKey();

        }
    }
}
