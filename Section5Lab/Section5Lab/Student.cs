﻿namespace Section5Lab
{
    class Student
    {
        private string studentName;
        private string sNumber;

        public string GetStudentName() { return this.studentName; }
        public void SetStudentName(string studentName) { this.studentName = studentName; }

        public string GetSNumber() { return this.sNumber; }
        public void SetSNumber(string sNumber) { this.sNumber = sNumber; }

        /*public Student (string studentName, string sNumber)
        {
            this.studentName = studentName;
            this.sNumber = sNumber;
        }
        */
    }
}
