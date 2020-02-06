using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1.Models
{
    public class CPU
    {
        public CPU(int mhz, int cores)
        {
            Mhz = mhz;
            Cores = cores;
        }

        public int Mhz { get; private set; }
        public int Cores { get; private set; }
    }
}
