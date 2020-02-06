using System;
using System.Collections.Generic;
using System.Text;

namespace LibrariesProject
{
    public class Tablet : Computer
    {
        public Tablet(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }

        public bool Battery { get; private set; }
    }
}
