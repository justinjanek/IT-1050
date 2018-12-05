using System;
namespace Section4Lab
{
    public class IO
    {
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        int childTickets = int.Parse(Console.ReadLine());

        public static string Input()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
