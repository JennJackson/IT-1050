using System;

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

            double smallSodaPrice = 3.50;
            double largeSodaPrice = 5.99;
            double hotDogPrice = 3.99;
            double popcornPrice = 4.50;
            double candyPrice = 1.99;

            int smallSodaCount = 0;
            int largeSodaCount = 0;
            int hotDogCount = 0;
            int popcornCount = 0;
            int candyCount = 0;
            int concessionCount = 0;
            int freePopcornCount = 0;
            int freeCandyCount = 0;

            double concessionPriceTotal = 0;
            double ticketPriceTotal = 0;
            double ticketDiscountTotal = 0;


            System.Console.WriteLine("Will you be purchasing matinee or evening tickets?");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter [1] for Matinee or [2] for Evening.");
            System.Console.Write("---> ");

            // These don't work
            #region
            // Pressing 1 or 2 will continue forever.
            //while (System.Console.ReadKey(true).Key != System.ConsoleKey.NumPad1 || System.Console.ReadKey(true).Key != System.ConsoleKey.NumPad2) { }

            //will force you to enter in twice
            //while (System.Console.ReadKey(true).Key != System.ConsoleKey.NumPad1 && System.Console.ReadKey(true).Key != System.ConsoleKey.NumPad2) { }
            #endregion
                                   
            System.ConsoleKey key;
            //while ((key = System.Console.ReadKey(true).Key) != System.ConsoleKey.NumPad1 && key != System.ConsoleKey.NumPad2) ;
            // need to assign a variable to user input to record it and keep it. Also works
            while (!getValidKey(out key));

            if (key == ConsoleKey.NumPad1 || key == ConsoleKey.D1)
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
            else if (key == ConsoleKey.NumPad2 || key == ConsoleKey.D2)
            {
                // Evening
                System.Console.WriteLine();
                System.Console.WriteLine("+----------------------------------------------+");
                System.Console.WriteLine(" Evening Prices");
                System.Console.WriteLine("+----------------------------------------------+");
                System.Console.WriteLine(" Adult: $" + adultEveningPrice);
                System.Console.WriteLine(" Child: $" + childEveningPrice);
                System.Console.WriteLine(" Senior: $" + seniorEveningPrice);
                System.Console.WriteLine("+----------------------------------------------+");
                System.Console.WriteLine(" Specials");
                System.Console.WriteLine("+----------------------------------------------+");
                System.Console.WriteLine(" - Buy 3 tickets, get 1 bag of popcorn, free!");
                System.Console.WriteLine("+----------------------------------------------+");
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
                System.Console.WriteLine("+------------------------------------------------------+");
                System.Console.WriteLine(" Concession Prices");
                System.Console.WriteLine("+------------------------------------------------------+");
                System.Console.WriteLine(" Small Soda: $" + smallSodaPrice);
                System.Console.WriteLine(" Large Soda: $" + largeSodaPrice);
                System.Console.WriteLine(" Hot Dog: $" + hotDogPrice);
                System.Console.WriteLine(" Popcorn: $" + popcornPrice);
                System.Console.WriteLine(" Candy: $" + candyPrice);
                System.Console.WriteLine("+-----------------------------------------------------+");
                System.Console.WriteLine(" Specials ");
                System.Console.WriteLine("+-----------------------------------------------------+");
                System.Console.WriteLine(" - Buy popcorn & a large soda, get $2 off your ticket");
                System.Console.WriteLine(" - Buy 3 candies, get 1 free");
                System.Console.WriteLine("+-----------------------------------------------------+");
                System.Console.WriteLine();

                System.Console.WriteLine("How many small sodas would you like to buy?");
                System.Console.Write("---> ");
                smallSodaCount = int.Parse(System.Console.ReadLine());
                double smallSodaTotal = smallSodaCount * smallSodaPrice;

                System.Console.WriteLine("How many large sodas would you like to buy?");
                System.Console.Write("---> ");
                largeSodaCount = int.Parse(System.Console.ReadLine());
                double largeSodaTotal = largeSodaCount * largeSodaPrice;

                System.Console.WriteLine("How many hot dogs would you like to buy?");
                System.Console.Write("---> ");
                hotDogCount = int.Parse(System.Console.ReadLine());
                double hotDogTotal = hotDogCount * hotDogPrice;

                System.Console.WriteLine("How many bags of popcorn would you like to buy?");
                System.Console.Write("---> ");
                popcornCount = int.Parse(System.Console.ReadLine());
                double popcornTotal = popcornCount * popcornPrice;

                System.Console.WriteLine("How many bags of candy would you like buy?");
                System.Console.Write("---> ");
                System.Console.WriteLine();
                candyCount = int.Parse(System.Console.ReadLine());
                double candyTotal = candyCount * candyPrice;


                concessionCount = smallSodaCount + largeSodaCount + hotDogCount + popcornCount + candyCount;
                concessionPriceTotal = smallSodaTotal + largeSodaTotal + hotDogTotal + popcornTotal + candyTotal;

                while (popcornCount >= 1 && largeSodaCount >= 1 && ticketPriceTotal >= 2)
                {
                    popcornCount--;
                    largeSodaCount--;
                    ticketDiscountTotal += 2;
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
                System.Console.WriteLine();
                System.Console.WriteLine("No concessions added.");
                System.Console.WriteLine();
            }
        

            double finalPrice = concessionPriceTotal + ticketPriceTotal;

            System.Console.WriteLine("+--------------------------------+");
            System.Console.WriteLine(" Adult Tickets: " + adultTicketCount);
            System.Console.WriteLine(" Children Tickets: " + childTicketCount);
            System.Console.WriteLine(" Senior Tickets: " + seniorTicketCount);
            System.Console.WriteLine("+--------------------------------+");
            System.Console.WriteLine(" Concessions Purchased: " + concessionCount);
            System.Console.WriteLine(" Free popcorn earned: " + freePopcornCount);
            System.Console.WriteLine(" Free candy earned: " + freeCandyCount);

            System.Console.WriteLine("+--------------------------------+");
            System.Console.WriteLine(" Discount earned on tickets: $" + ticketDiscountTotal);
            System.Console.WriteLine(" Ticket Total: $" + ticketPriceTotal);
            System.Console.WriteLine(" Concessions Total: $" + concessionPriceTotal);
            System.Console.WriteLine("+================================+");
            System.Console.WriteLine(" Final Total: $" + finalPrice);
            System.Console.ReadKey();

        }



        /////////////////////////////////////////////////////////////////////////

        private static bool getValidKey(out ConsoleKey key)
        {
            key = System.Console.ReadKey(true).Key;

            return key == System.ConsoleKey.NumPad1 || key == System.ConsoleKey.NumPad2 || key == System.ConsoleKey.D1 || key == System.ConsoleKey.D2;
        }
    }
}
