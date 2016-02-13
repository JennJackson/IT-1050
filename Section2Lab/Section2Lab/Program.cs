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
            
            p1.AskForPersonInfo();    
            p2.AskForPersonInfo();
            
            p1.PrintNameAndAge();
            p1.spouse.PrintNameAndAge();

            p2.PrintNameAndAge();
            p2.spouse.PrintNameAndAge();

            Person.PrintAverageAge();
            
            //End program

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
