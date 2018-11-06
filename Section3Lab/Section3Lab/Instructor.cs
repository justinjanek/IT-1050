using System;
namespace Section3Lab
{
    public class Instructor
    {
    
        public string Name { get; set; }
        public string CourseName { get; set; }

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student NameOfStudent, int Grade)
        {
            NameOfStudent.Grade = Grade;
        }

        public void PrintInstructorInfo()
        {
            Console.WriteLine(this.Name + this.CourseName);
        }
    }
}
