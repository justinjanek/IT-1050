using System;

namespace Section2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Spouse = new Person();
            p2.Spouse = new Person();

            p1.GatherInfoAboutUser("p1");
            p2.GatherInfoAboutUser("p2");

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            Person.PrintAverageAge();

            System.Console.ReadKey();
        }
    }
}
