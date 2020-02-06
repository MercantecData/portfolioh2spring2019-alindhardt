using System;

namespace LibrariesProjectTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLaptop = new LibrariesProject.Laptop("HP", 2400, 4);
            if (!myLaptop.LidOpen)
            {
                Console.WriteLine("Opening laptop lid!!!");
                myLaptop.ChangeLidState();
            }
        }
    }
}
