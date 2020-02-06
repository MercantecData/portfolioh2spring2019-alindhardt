using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1.Models
{
    public class SmartWatch : Computer
    {
        public SmartWatch(string manufacturer, int cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
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
