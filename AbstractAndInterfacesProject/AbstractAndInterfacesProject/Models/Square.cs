using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public class Square : Shape
    {
        public override void Draw()
        {
            var text = @"
 _
|_|
";
            Console.WriteLine(text);
        }
    }
}
