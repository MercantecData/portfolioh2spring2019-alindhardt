using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Drawing { get; set; }

        public abstract void Draw();
    }
}
