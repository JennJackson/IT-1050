namespace Section2Lab
{
    class Person
    {

        // Variable Declaration

        public int age;
        public string firstName;
        public string lastName;
        public bool isMarried;
        public Person spouse;

        // Statics

        public static int personCount = 0;
        public static double sumOfAllAges;

        // Methods

        public void AskForPersonInfo()              // Gets both person and their spouse info (if applicable)
        {

            personCount++;

            // Person info

            System.Console.Write("What is your first name?          : ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name?           : ");
            lastName = System.Console.ReadLine();

            System.Console.Write("What is your age?                 : ");
            age = int.Parse(System.Console.ReadLine());
            
            // Spouse info
                    
            System.Console.Write("Are you married? (True/False)     : ");
            isMarried = bool.Parse(System.Console.ReadLine());
            
            // ADD THIS
            // IF MARRIED, THEN CREATE SPOUSE

            spouse = new Person();

            personCount++;
                        
            spouse.isMarried = isMarried;

            System.Console.Write("Enter your spouse's first name    : ");
            spouse.firstName = System.Console.ReadLine();

            spouse.lastName = lastName;

            System.Console.Write("What is the age of your spouse?   : ");
            spouse.age = int.Parse(System.Console.ReadLine());

            this.spouse.spouse = this;      // relates 2nd person object (spouse) back to root of the class (first object) using ' = this '

            // The spouse of my spouse...
            // spouse.spouse = spouse;      -- not what I want

            sumOfAllAges += age + spouse.age;

        }

        public string GetFullName()             // Concatenates first/last names of each person object
        {

            string fullName = this.firstName + " " + this.lastName;
            return fullName;

        }

        public void PrintNameAndAge()           // Prints name/age of each person object
        {
            
            System.Console.WriteLine(this.GetFullName() + " (" + this.age + ")");
                                    
        }

        public static void PrintAverageAge()    // Calculates average age from the sum of all person objects' ages
        {

            System.Console.WriteLine("Average age: " + sumOfAllAges / personCount);

        }


    }
}
