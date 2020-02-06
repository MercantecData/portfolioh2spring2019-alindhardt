using System;

namespace LibrariesProject
{
    public class Motherboard
    {
        public string Type { get; private set; } = "ATX";
        public string[] IO { get; private set; } = new string[] { "USB1", "USB2" };

        public void Boot()
        {
            Console.WriteLine("I AM BOOTING!!!");
        }
    }
}
