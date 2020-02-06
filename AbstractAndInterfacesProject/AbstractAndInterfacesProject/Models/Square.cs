using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public class Square : Shape
    {
        public Square()
        {
            Drawing = @"
 _
|_|
";
        }
        public override void Draw()
        {
            Console.WriteLine(Drawing);
        }
    }
}
