namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // TO DO: ASSIGN SAME LAST NAME TO SPOUSES
            // TO DO: ASSIGN ISMARRIED: TRUE VALUE TO SPOUSE OBJECT IF FIRST OBJECT ISMARRIED IS TRUE
            // TO DO: ADD IF/THEN TO SPOUSE QUESTION

            // TO DO: SUMOFALLAGES
            // TO DO: STATICS
            

            //**********************************//
            //Declare/Instantiate Person objects//
            //**********************************//

            Person p1 = new Person();
            Person p2 = new Person();

            //*************************************//
            //Invoke methods for each Person object//
            //*************************************//

            p1.AskForNameAndAge();
            p1.AskForSpouseName();
            p1.PrintNameAndAge();

            p2.AskForNameAndAge();
            p2.AskForSpouseName();
            p2.PrintNameAndAge();
            
            //***********//
            //End program//
            //***********//

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
