namespace Section5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the course creator.");

            System.Console.Write("Would you like to create a new course?    : ");
            string createCourse = System.Console.ReadLine();
            if (createCourse.ToLower().Contains("y"));
            {
                Course.GetCourseInfo();
            }
            //Course.SetStudentList(students[]);

           

            //stem.Console.WriteLine(Course.GetStudentList());

            System.Console.ReadKey();
        }
    }
}
