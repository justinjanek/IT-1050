using System;
namespace Section3Lab
{
    public class Student
    {

        public string Name { get; set; }
        public int Grade { get; set; }
        public Instructor Teacher { get; set; }

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = 0;
        }

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student: " + this.Name);
            Console.WriteLine("Instructor: " + this.Teacher.Name);
            Console.WriteLine("Course: " + this.Teacher.CourseName);
            Console.WriteLine("Grade: " + this.Grade + "\n");
        }
    }
}
