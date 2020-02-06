using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1.Models
{
    public class Computer
    {
        /// <summary>
        /// Initialize Computer with manufacturer and specific cpu Mhz and cores.
        /// </summary>
        /// <param name="manufacturer">The name of the computer manufacturer</param>
        /// <param name="cpuMhz">The number of Mhz in the computer's CPU</param>
        /// <param name="cpuCores">The number of cores in the computer's CPU</param>
        public Computer(string manufacturer, int cpuMhz, int cpuCores)
        {
            Manufacturer = manufacturer;
            CPU = new CPU(cpuMhz, cpuCores);
        }

        public string Manufacturer { get; private set; }
        public Motherboard Motherboard { get; private set; }
        public CPU CPU { get; private set; }
        public bool PoweredOn { get; private set; }

        public void ChangePowerState()
        {
            PoweredOn = PoweredOn ? false : true;
        }
    }
}
