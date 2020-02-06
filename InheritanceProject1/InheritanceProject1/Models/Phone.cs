using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1.Models
{
    public class Phone : Computer
    {
        public Phone(string manufacturer, float cpuMhz, int cpuCores) : base(manufacturer, cpuMhz, cpuCores)
        {

        }

        public bool Battery { get; set; }

        public void Call(string phoneNumber)
        {
            Console.WriteLine("Calling: {0}", phoneNumber);
        }
    }
}
