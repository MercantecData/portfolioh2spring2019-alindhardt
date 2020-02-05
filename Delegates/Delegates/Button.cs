using Delegates.MyDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Button
    {
        public Button(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void Press(ButtonPress buttonPress)
        {
            Console.WriteLine("Who dares pressing the mighty {0}!?", Name);
            buttonPress();
        }
    }
}
