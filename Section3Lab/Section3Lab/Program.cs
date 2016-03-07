namespace Section3Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor1 = new Instructor("John", "English");
            Instructor instructor2 = new Instructor("Mike", "Math");

            Student student1 = new Student("Jane", instructor1);
            Student student2 = new Student("Joe", instructor1);
            Student student3 = new Student("Melissa", instructor2);
            Student student4 = new Student("Matt", instructor2);

            student1.PrintStudentInfo();
            student2.PrintStudentInfo();
            student3.PrintStudentInfo();
            student4.PrintStudentInfo();

            System.Console.ReadKey();
        }
    }
}
