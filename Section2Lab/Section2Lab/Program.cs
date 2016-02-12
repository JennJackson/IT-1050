namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Needs more spouse-ception

            // TO DO: MAKE SPOUSE OF FIRST OBJECT POINT BACK AT FIRST OBJECT....(p1 --> spouse. NEED spouse --> p1).
                    // p1 points at spouse, need spouse to point back at p1

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
            p1.AskForSpouseInfo();
            p1.PrintNameAndAge();

            p2.AskForNameAndAge();
            p2.AskForSpouseInfo();
            p2.PrintNameAndAge();
            
            //***********//
            //End program//
            //***********//

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
