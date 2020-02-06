using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public class Triangle : Shape
    {
        public Triangle()
        {
            Drawing = @"
 _        _                   _      
| |      (_)                 | |     
| |_ _ __ _  __ _ _ __   __ _| | ___ 
| __| '__| |/ _` | '_ \ / _` | |/ _ \
| |_| |  | | (_| | | | | (_| | |  __/
 \__|_|  |_|\__,_|_| |_|\__, |_|\___|
                         __/ |       
                        |___/       
";
        }

        public override void Draw()
        {
            Console.WriteLine(Drawing);
        }
    }
}
