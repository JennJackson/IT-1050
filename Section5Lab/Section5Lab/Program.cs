namespace Section5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int count = Question.AskForInteger("How many items do you want to add? ");

            Widget[] items = new Widget[count];
            */
            System.Console.WriteLine("Welcome to the course creator.");
            System.Console.Write("Please enter the name of the course       : ");

            string courseName = System.Console.ReadLine();
            System.Console.Write("Please enter the course number            : ");
            string crnNumber = System.Console.ReadLine();

            Course course1 = new Course(courseName, crnNumber);

            System.Console.Write("How many students are in this course?     : ");
            int studentCount = int.Parse(System.Console.ReadLine());

            Student[] students = new Student[studentCount];

        }
    }
}
