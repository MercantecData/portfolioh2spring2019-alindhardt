using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var triangle = new Models.Triangle();
            //Abstract method from Shape.cs
            triangle.Draw();

            //Abstract method from ICopyAndPastetable.cs
            triangle.Copy();
        }
    }
}
