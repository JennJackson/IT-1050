namespace Section2Lab
{
    class Person
    {

        public int age;
        public string firstName;
        public string lastName;
        public bool isMarried;
        public Person spouse;

        public static double sumOfAllAges;


        public void AskForNameAgeAndSpouse()
        {

            // Person info

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.Write("What is your age? ");
            age = int.Parse(System.Console.ReadLine());
            
            // Spouse info
                    
            System.Console.Write("Are you married? (True/False) ");
            isMarried = bool.Parse(System.Console.ReadLine());
            
            // ADD THIS
            // IF MARRIED, THEN CREATE SPOUSE

            spouse = new Person();
                        
            spouse.isMarried = isMarried;

            System.Console.Write("What is the first name of your spouse? ");
            spouse.firstName = System.Console.ReadLine();

            spouse.lastName = lastName;

            System.Console.Write("What is the age of your spouse? ");
            spouse.age = int.Parse(System.Console.ReadLine());

            this.spouse.spouse = this;      // relates 2nd person object (spouse) back to root of the class (first object) using ' = this '

            // The spouse of my spouse...
            // spouse.spouse = spouse;      -- not what I want


            // close but not functioning properly
            //sumOfAllAges += (age += spouse.age) / 2;
              
        }

        public string GetFullName()
        {

            string fullName = this.firstName + " " + this.lastName;
            return fullName;

        }

        public void PrintNameAndAge()
        {

            System.Console.WriteLine(this.GetFullName() + " (" + this.age + ")");
                        
        }


    }
}
