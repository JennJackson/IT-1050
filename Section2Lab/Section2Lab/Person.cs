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


        public void AskForNameAndAge()
        {

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.Write("What is your age? ");
            age = int.Parse(System.Console.ReadLine());

        }

        public void AskForSpouseInfo()
        {

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

            


            // The spouse of my spouse is myself...
            // spouse.spouse = spouse;
            // I need to point back at spouse #1...first object
              
        }

        public string GetFullName()
        {

            string fullName = this.firstName + " " + this.lastName;
            return fullName;

        }

        public void PrintNameAndAge()
        {

            System.Console.WriteLine("Full Name: " + this.GetFullName());
            System.Console.WriteLine("Age: " + this.age);

        }


    }
}
