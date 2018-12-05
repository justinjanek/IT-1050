using System;
namespace Section4Lab
{
    public static class Purchase
    {
        public static void PurchaseDialogue()
        {
            double totalCost = 0;
            double totalDiscount = 0;
            double finalCost = 0;

            Console.WriteLine("How many of the following tickets would you like to purchase? ");

            Console.Write("Day - Child: ");
            int dayChildTickets = int.Parse(Console.ReadLine());

            Console.Write("Day - Adult: ");
            int dayAdultTickets = int.Parse(Console.ReadLine());

            Console.Write("Day - Senior: ");
            int daySeniorTickets = int.Parse(Console.ReadLine());


            Console.Write("Evening - Child: ");
            int eveChildTickets = int.Parse(Console.ReadLine());

            Console.Write("Evening - Adult: ");
            int eveAdultTickets = int.Parse(Console.ReadLine());

            Console.Write("Evening - Senior: ");
            int eveSeniorTickets = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("How many of the following concession items would you like? ");

            Console.Write("Large Soda: ");
            int largeSodaCount = int.Parse(Console.ReadLine());

            Console.Write("Small Soda: ");
            int smallSodaCount = int.Parse(Console.ReadLine());

            Console.Write("Hot Dog: ");
            int hotDogCount = int.Parse(Console.ReadLine());

            Console.Write("Popcorn: ");
            int popCornCount = int.Parse(Console.ReadLine());

            Console.Write("Candy: ");
            int candyCount = int.Parse(Console.ReadLine());

            totalCost += dayChildTickets * Price.DayChildTicket;
            totalCost += dayAdultTickets * Price.DayAdultTicket;
            totalCost += daySeniorTickets * Price.DaySeniorTicket;
            totalCost += eveChildTickets * Price.DayChildTicket;
            totalCost += eveAdultTickets * Price.DayAdultTicket;
            totalCost += eveSeniorTickets * Price.DaySeniorTicket;

            int totalDayTicketCount = dayChildTickets + dayAdultTickets + daySeniorTickets;
            int totalEveTicketCount = eveChildTickets + eveAdultTickets + eveSeniorTickets;
            int totalTicketCount = totalDayTicketCount + totalEveTicketCount;

            totalCost += largeSodaCount * Price.LargeSoda;
            totalCost += smallSodaCount * Price.SmallSoda;
            totalCost += hotDogCount * Price.HotDog;
            totalCost += popCornCount * Price.Popcorn;
            totalCost += candyCount * Price.Candy;


            // Discount 1
            int min1 = Math.Min(popCornCount, largeSodaCount);
            int min2 = Math.Min(min1, totalTicketCount);

            totalDiscount += (min2 * 2.0);

            // Discount 2
            if (totalEveTicketCount >= 3 && popCornCount >= 1)
            {
                totalDiscount += Price.Popcorn;
            }

            // Discount 3
            totalDiscount = (candyCount / 4) * Price.Candy;

            finalCost = totalCost - totalDiscount;

            Console.WriteLine();
            Console.Write("You saved " + totalDiscount + "!");
            Console.Write("Your total is: " + finalCost);

            Console.ReadKey();

        }
    }
}
