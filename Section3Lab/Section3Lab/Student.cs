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
    
        public void SetGrade(int grade)
        {
            this.grade = grade;
        }

        public void PrintStudentInfo()
        {
            System.Console.WriteLine("Student name: " + this.name);
            System.Console.WriteLine(this.name + "'s grade: " + this.grade);
            teacher.PrintInstructorInfo();
            System.Console.WriteLine();
        }
    }
}
