using System;
namespace Section5Lab
{
    public class Question
    {
   
        public static string AskForString(string question)
        {
            System.Console.WriteLine(question);
            string answer = System.Console.ReadLine();

            return answer;
        }

        public static int AskForInt(string question)
        {
            int answer = int.Parse(AskForString(question));

            if (answer >= Board.BOARDSIZE)
            {
               AskForInt("Please enter a number between 0 to 7");
            }

            return answer;
        }
    }
}
