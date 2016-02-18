namespace Section3Lab
{
    class Student
    {
        private string name;
        private int grade;
        private Instructor teacher;

        public Student(string name, Instructor teacher)
        {
            this.name = name;
            this.teacher = teacher;
            this.grade = 0;
        }

        public void SetGrade()
        {

        }

        public void PrintInfo()
        {
            System.Console.WriteLine("My name: " + this.name);
            System.Console.WriteLine("My grade: " + this.grade);
            System.Console.WriteLine("My teacher: " + this.teacher);
        }
    }
}
