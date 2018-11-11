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

        public void SetStudentGrade(Student Name, int Grade)
        {
            Name.SetGrade(Grade);
        }

        public void PrintInstructorInfo()
        {
            Console.WriteLine("Instructor: " + this.Name);
            Console.WriteLine("Course Name: " + this.CourseName);
            Console.WriteLine();
        }
    }
}
