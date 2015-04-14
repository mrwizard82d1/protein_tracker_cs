﻿using System;

namespace ProteinTrackerDotNetSlim
{
    public class CanIAddAndSubtractProteins
    {
        private TrackerService _sut = new TrackerService();

        public int Amount { get; set; }

        public String Operation { get; set; }

        // Will the .NET slim runner search for and invoke an `Execute` 
        // method?
        public void Execute()
        {
            if (Operation.Equals("add"))
            {
                _sut.AddProtein(Amount);
            } else if (Operation.Equals("subtract"))
            {
                _sut.RemoveProtein(Amount);
            }
        }

        public int TotalIs()
        {
            return _sut.Total;
        }

    }

    internal class TrackerService
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
