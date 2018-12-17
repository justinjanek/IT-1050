using System;
namespace Section5Lab
{
    public class Board
    {
        public const int BOARDSIZE = 8;
        public static string[][] grid = new string[BOARDSIZE][];

        public static void CreateBoard()
        {
            for (int i = 0; i < BOARDSIZE; i++)
            {
                grid[i] = new string[BOARDSIZE];

                for (int j = 0; j < BOARDSIZE; j++)
                {
                    grid[i][j] = (i < 2 || i > (BOARDSIZE - 3)) ? "X " : ". ";
                }
            }
        }

        public static void PrintBoard()
        {
            for (int i = 0; i < BOARDSIZE; i++)
            {
                System.Console.WriteLine();

                if (i == 0)
                {
                    System.Console.WriteLine("   0 1 2 3 4 5 6 7");
                    System.Console.WriteLine("   ---------------");
                }

                for (int j = 0; j < BOARDSIZE; j++)
                {
                    if (j == 0)
                    {
                        System.Console.Write(i + "| ");
                    }
                    System.Console.Write(grid[i][j]);
                }
            }
            System.Console.WriteLine("\n");
        }

        public static void UpdateBoard()
        {
            int sourceX = Question.AskForInt("What is the X Coordinate of the source pawn?");
            int sourceY = Question.AskForInt("What is the Y Coordinate of the source pawn?");
            int targetX = Question.AskForInt("What is the X Coordinate of the target pawn?");
            int targetY = Question.AskForInt("What is the Y Coordinate of the target pawn?");

            grid[targetX][targetY] = grid[sourceX][sourceY];
            grid[sourceX][sourceY] = ". ";

            System.Console.Clear();

            PrintBoard();
        }

        public static void AskToContinue()
        {
            string move = Question.AskForString("Would you like to make another move? [y/n]");

            if (move.ToLower().StartsWith('y'))
            {
                UpdateBoard();
                AskToContinue();
            }
            else if (move.ToLower().StartsWith('n'))
            {
                System.Console.WriteLine("Exiting program");
                System.Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("I didn't recongize that.");
                AskToContinue();
            }
        }

    }
}
