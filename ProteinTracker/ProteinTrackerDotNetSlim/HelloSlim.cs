﻿namespace ProteinTrackerDotNetSlim
{
    public class HelloSlim
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
