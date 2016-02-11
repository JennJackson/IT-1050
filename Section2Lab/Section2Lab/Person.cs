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

        public string GetFullName()
        {

            string fullName = "";
            fullName += this.firstName;
            fullName += " ";
            fullName += this.lastName;
            return fullName;

        }

        public void PrintNameAndAge()
        {

            System.Console.WriteLine("Full Name: " + this.GetFullName());
            System.Console.WriteLine("Age: " + this.age);

        }


    }
}
