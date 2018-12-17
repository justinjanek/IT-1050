using System;
namespace Final
{
    public class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            foreach (Passenger passenger in Occupants)
            {
                totalWeight += passenger.GetWeight();
            }

            return totalWeight;
        } 

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            return false;
        }
    }
}
