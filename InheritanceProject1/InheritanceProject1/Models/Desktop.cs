using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1.Models
{
    public class Desktop : Computer
    {
        /// <summary>
        /// Initialize Desktop with manufacturer and specific cpu Mhz and cores.
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="cpuMhz"></param>
        /// <param name="cpuCores"></param>
        public Desktop(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }

        public bool HasPsu { get; private set; }
    }
}
