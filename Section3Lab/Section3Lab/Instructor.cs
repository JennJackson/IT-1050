namespace Section3Lab
{
    class Instructor
    {
        private string name;
        private string courseName;
        private Student student;  // not using this right now?

        public Instructor (string name, string courseName)
        {
            this.name = name;
            this.courseName = courseName;
        }

        public void SetStudentGrade() // not using this yet
        {
            student.GetStudentName();


        }

        public void PrintInstructorInfo()
        {
            System.Console.WriteLine("Instructor name: " + this.name);
            System.Console.WriteLine("Course name: " + this.courseName);
        }
    }
}
