using System;

namespace Section2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Declare variable
            //      Person john;
            // Then instatiate the object (with new)
            //      john = new Person;

            Person justin = new Person();
            Person nick = new Person();
            State ohio = new State();

            justin.firstName = "Justin";
            justin.middleInitial = "E";
            justin.lastName = "Janek";
            justin.age = 23;
            justin.state = ohio;

            nick.firstName = "Nick";
            nick.middleInitial = "R";
            nick.lastName = "Janek";
            nick.age = 25;
            nick.state = ohio;

            Person oldestPerson = nick;
            Person youngestPerson = justin;

            ohio.nameOfState = "Ohio";
            ohio.abbreviation = "OH";
            ohio.capital = "Columbus";
            ohio.population = 11660000;

            justin.stateYourNameAgeAndState();
            nick.stateYourNameAgeAndState();

            System.Console.ReadKey();








        }
    }
}
