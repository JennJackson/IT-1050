namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();

            System.Console.Write("What is your first name? ");
            p1.firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            p1.lastName = System.Console.ReadLine();

            System.Console.Write("What is your age? ");
            p1.age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you married? (Yes/No) ");
            p1.isMarried = bool.Parse(System.Console.ReadLine());

            System.Console.Write("What is the first name of your spouse? ");
            p1.spouse = System.Console.ReadLine();

            System.Console.Write("What is the age of your spouse? ");
            p1.spouse = System.Console.ReadLine();

            //p1.spouse;

            Person p2 = new Person();
            //p2.spouse;

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
