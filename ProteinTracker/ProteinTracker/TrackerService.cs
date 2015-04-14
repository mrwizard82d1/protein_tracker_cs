namespace ProteinTracker
{
    public class TrackerService
    {
        public int Total { get; private set; }

        public void AddProtein(int amount)
        {
            Total += amount;
        }

        public void RemoveProtein(int amount)
        {
            Total -= amount;
            if (Total < 0)
            {
                Total = 0;
            }
        }
    }
}