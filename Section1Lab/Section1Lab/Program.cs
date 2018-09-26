using System;

namespace Section1Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DeclaringVariables
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            const double inchToCmMultiplier = 2.54;
            const int inchesIn1Foot = 12;
            #endregion DeclaringVariables

            #region Name
            System.Console.WriteLine("Hi! We'll be asking you a few questions about yourself.\n");
            System.Console.Write("To begin, could you please print your first name?: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Middle initial?: ");
            middleInitial = System.Console.ReadLine() + ".";

            System.Console.Write("And what is your last name?: ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;
            System.Console.WriteLine("\nThanks, " + fullName + "!");
            #endregion Name

            #region Height
            System.Console.Write("\nHow many feet tall are you?: ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches are you beyond your height in feet?: ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * inchesIn1Foot) + heightInches) * inchToCmMultiplier;
            System.Console.WriteLine("\nYou are " + totalHeightCM + " centimeters tall.");
            #endregion Height

            // Age
            System.Console.Write("\nAnd how old are you?: ");
            age = int.Parse(System.Console.ReadLine());


            // Citizen?
            System.Console.Write("Are you a U.S. citizen, 'true' or 'false'?: ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = age >= 18 && isCitizen;

            System.Console.Write("\nIt is " + canVote + " that you can vote.");
        }
    }
}