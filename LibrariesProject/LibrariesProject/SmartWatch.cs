using System;
using System.Collections.Generic;
using System.Text;

namespace LibrariesProject
{
    public class SmartWatch : Computer
    {
        public SmartWatch(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }

        public bool Battery { get; private set; }

        public void MeasurePulse()
        {
            Console.WriteLine("Measuring pulse...");
            Console.WriteLine("No pulse found.");
        }
    }
}
