namespace FinalProject
{
    class Elevator
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
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double CurrentWeight = 0;
            for (int i = 0; i < Occupants.Length; i++)
            {
                CurrentWeight = CurrentWeight + Occupants[i].GetWeight();
            }
            return CurrentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            bool OverMaxCapacity = true;
            if (GetCurrentWeight() > MaxWeight)
            {
                OverMaxCapacity = true;
            }
            else
            {
                OverMaxCapacity = false;
            }
            return OverMaxCapacity;
        }
    }
}
