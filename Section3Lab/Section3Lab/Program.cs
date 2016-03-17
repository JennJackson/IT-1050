namespace Section3Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program purpose:
            // Creates new Instructor objects
            // Creates new Student objects
            // Instructors can set their students' grades
            // Student info prints out to the screen after entering grades
            
            Instructor instructor1 = new Instructor("John", "English");
            Instructor instructor2 = new Instructor("Mike", "Math");

            Student student1 = new Student("Jane", instructor1);
            Student student2 = new Student("Joe", instructor1);
            Student student3 = new Student("Melissa", instructor2);
            Student student4 = new Student("Matt", instructor2);

            instructor1.SetStudentGrade(student1, 95);
            instructor1.SetStudentGrade(student2, 85);
            instructor2.SetStudentGrade(student3, 90);
            instructor2.SetStudentGrade(student4, 92);

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
