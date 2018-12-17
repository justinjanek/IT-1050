using System.Collections.Generic;

namespace Section5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Board.CreateBoard();
            Board.PrintBoard();
            Board.UpdateBoard();
            Board.AskToContinue();

            System.Threading.Thread.Sleep(50000);
        }
    }
}
