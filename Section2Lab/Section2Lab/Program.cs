namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PROGRAM PURPOSE:
                - Takes in name, age, and marital status of a person (Person object).
                - Asks if the person has a spouse, and if so, creates another connected person object.
                - Keeps track of the number of person objects and the sum of all of their ages.
                - Finds the average age of all person objects.
                - Prints out all info to console.
            */
            
            //Declare/Instantiate Person objects

            Person p1 = new Person();
            Person p2 = new Person();

            //Invoke methods for each Person object

            // Person 1 info

            System.Console.WriteLine("Enter information for person 1: ");
            System.Console.WriteLine();

            p1.AskForPersonInfo();

            // Person 2 info

            System.Console.WriteLine();
            System.Console.WriteLine("Enter information for person 2: ");
            System.Console.WriteLine();
              
            p2.AskForPersonInfo();

            // Print results for all person objects

            System.Console.WriteLine();
            System.Console.WriteLine("Results: ");
            System.Console.WriteLine();

            p1.PrintNameAndAge();               // Print age of person 1

            if (p1.isMarried)                   // If person 1 is married, print their spouse's age
            {
                p1.spouse.PrintNameAndAge();
            }

            p2.PrintNameAndAge();               // Print age of person 2

            if (p2.isMarried)                   // If person 2 is married, print their spouse's age
            {
                p2.spouse.PrintNameAndAge();
            }

            System.Console.WriteLine();
            Person.PrintAverageAge();           // Print average age of all person objects

            //End program

            System.Console.WriteLine();
            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
