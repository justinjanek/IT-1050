using System;
namespace Section2Practice
{
    public class Person
    {
        // Member Variable Decleration
        // aka Instance Variable Decleration

        public string firstName;
        public string middleInitial;
        public string lastName;

        public int age;
        public State state;

        public string getFullName()
        {
            return this.firstName + " " + this.middleInitial + ". " + this.lastName;
        }

        public void stateYourNameAgeAndState()
        {
            System.Console.WriteLine(this.firstName + " says, 'Hello'.");
            System.Console.WriteLine("My name is " + this.getFullName());
            System.Console.WriteLine("My age is " + this.age);
            System.Console.WriteLine("I live in " + this.state.nameOfState);
        }
    }
}
