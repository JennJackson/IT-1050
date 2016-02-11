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
