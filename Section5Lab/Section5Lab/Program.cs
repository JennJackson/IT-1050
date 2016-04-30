namespace Section5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the course creator.");

            System.Console.Write("Would you like to create a new course? (y/n)  : ");
            string createCourse = System.Console.ReadLine();
            if (createCourse.ToLower().Contains("y"))
            {

                Course course = Course.GetCourseInfo();

                System.Console.Write("Is all the information correct? (y/n) : ");
                string correctCourseInfo = System.Console.ReadLine();
                while (correctCourseInfo.ToLower().Contains("n"))
                {
                    System.Console.WriteLine("Please reenter course information.");
                    course = Course.GetCourseInfo();
                    System.Console.Write("Is all the information correct? (y/n) : ");
                    correctCourseInfo = System.Console.ReadLine();
                }
            }
            else if (createCourse.ToLower().Contains("n"))
            {
                System.Console.WriteLine("Exiting course creator.");
            }

            System.Console.WriteLine("Press any key to continue");
            System.Console.ReadKey();
        }
    }
}
