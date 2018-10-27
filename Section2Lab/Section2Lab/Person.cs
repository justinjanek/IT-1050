using System;
namespace Section2Lab
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges = 0;
        public static double AverageAge = SumOfAllAges / 4;

        public void GatherInfoAboutUser(string name)
        {
            System.Console.WriteLine("Enter info for " + name);

            this.FirstName = Question.AskForString("What is your first name?");
            this.LastName = Question.AskForString("What is your last name?");
            this.Age = Question.AskForInteger("How old are you?");

            this.Spouse.LastName = this.LastName;
            this.Spouse.FirstName = Question.AskForString("What is your spouse's first name?");
            this.Spouse.Age = Question.AskForInteger("How old is your spouse?");

            System.Console.WriteLine();

            SumOfAllAges += this.Age;
            SumOfAllAges += this.Spouse.Age;

        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName() + ", Age " + this.Age);
        }

        public static void PrintAverageAge()
        {
            System.Console.WriteLine("Average age = " Person.AverageAge);
        }
    }
}
