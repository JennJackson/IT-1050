namespace Section5Lab
{
    class Course
    {
        private string courseName;
        private string crnNumber;
        private Student[] students;

        /*
                public static Student GetStudentList() { return Course.studentList; }
                public static void SetStudentList(Student students)
                {
                    studentList = students;

                }*/

        public Course(string courseName, string crnNumber, Student[] students)
        {
            this.courseName = courseName;
            this.crnNumber = crnNumber;
            this.students = students;
        }

        public static Course GetCourseInfo()
        {
            System.Console.Write("Please enter the name of the course       : ");

            string courseName = System.Console.ReadLine();
            System.Console.Write("Please enter the course number            : ");
            string crnNumber = System.Console.ReadLine();
                        
            System.Console.Write("How many students are in this course?     : ");
            int studentCount = int.Parse(System.Console.ReadLine());

            Student[] students = new Student[studentCount];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                System.Console.Write("Enter the student name                    : ");
                string studentName = System.Console.ReadLine();
                students[i].SetStudentName(studentName);
                System.Console.Write("Enter the student number                  : ");
                string sNumber = System.Console.ReadLine();
                students[i].SetSNumber(sNumber);
            }

            Course course = new Course(courseName, crnNumber, students);

            foreach (Student student in students)
            {
                System.Console.WriteLine("Student Name: " + student.GetStudentName() + ", sNumber: " + student.GetSNumber());
            }

            return course;
        }
    }
}
