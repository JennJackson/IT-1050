namespace Section3Lab
{
    class Instructor
    {
        private string name;
        private string courseName;

        public Instructor (string name, string courseName)
        {
            this.name = name;
            this.courseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
            student.PrintStudentInfo();
        }

        public void PrintInstructorInfo()
        {
            System.Console.WriteLine("Instructor name: " + this.name);
            System.Console.WriteLine("Course name: " + this.courseName);
        }
    }
}
