namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // TO DO: ADD IF/THEN TO SPOUSE QUESTION
            // TO DO: STATICS
            // TO DO: pretty-fy ui
            
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

            p1.PrintNameAndAge();
            p1.spouse.PrintNameAndAge();

            p2.PrintNameAndAge();
            p2.spouse.PrintNameAndAge();

            System.Console.WriteLine();

            Person.PrintAverageAge();

            //End program

            System.Console.WriteLine();
            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
