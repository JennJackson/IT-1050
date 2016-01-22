namespace Section1Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variable declarations

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int userAge;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            // Program output and user input

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;
            
            System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many INCHES beyond your height in feet are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12 * 2.54) + (heightInches * 2.54));

            System.Console.Write("What is your age? ");
            userAge = int.Parse(System.Console.ReadLine());

            System.Console.Write(@"Are you a citizen of the United States of America? (Write ""true"" or ""false"") ");
            isCitizen = bool.Parse(System.Console.ReadLine());
            canVote = isCitizen && userAge >= 18;

            // print info

            System.Console.WriteLine("Your full name is: " + fullName + ".");
            System.Console.WriteLine("Your height in centimeters: " + totalHeightCM + ".");
            System.Console.WriteLine("Eligible to vote: " + canVote + ".");
                                    
            // end command

            System.Console.WriteLine("Press any key to continue... ");
            System.Console.ReadKey();

        }
    }
}
