using System;
using System.Collections.Generic;
using System.Text;

namespace LibrariesProject
{
    public class CPU
    {
        public CPU(float mhz, int cores)
        {
            Mhz = mhz;
            Cores = cores;
        }

        public float Mhz { get; private set; }
        public int Cores { get; private set; }
    }
}
