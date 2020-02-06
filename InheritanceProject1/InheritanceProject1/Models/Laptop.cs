using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1.Models
{
    public class Laptop : Computer
    {
        public Laptop(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }

        public bool Battery { get; private set; }
        public bool LidOpen { get; private set; }

        public void ChangeLidState()
        {
            LidOpen = LidOpen ? false : true;
        }
    }
}
