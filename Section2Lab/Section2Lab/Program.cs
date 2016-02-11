namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // NEED TO INCLUDE SPOUSES IN METHOD AND DECLARE SPOUSE VARIABLES.
            // WORKING W.O SPOUSES 


            Person p1 = new Person();
            /*

            System.Console.Write("Are you married? (Yes/No) ");
            p1.isMarried = bool.Parse(System.Console.ReadLine());
            
            System.Console.Write("What is the first name of your spouse? ");
            p1.spouse = System.Console.ReadLine();

            System.Console.Write("What is the age of your spouse? ");
            p1.spouse = System.Console.ReadLine();
            */
            

            Person p2 = new Person();

            p1.AskForNameAndAge();
            p1.PrintNameAndAge();

            p2.AskForNameAndAge();
            p2.PrintNameAndAge();
            

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
