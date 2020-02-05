using Delegates.MyDelegates;
using Delegates.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Controller
    {
        public Controller(string modelName, string manufacturer)
        {
            ModelName = modelName;
            Manufacturer = manufacturer;

            Button1.Press(PressingButton);
        }

        public string ModelName { get; private set; }
        public string Manufacturer { get; private set; }
        public Button Button1 { get; set; } = new Button("Button1");
        public Button Button2 { get; set; }

        public void PressingButton()
        {
            Console.WriteLine("Me, {0} from {1} is pressing you!", ModelName, Manufacturer);
        }
    }
}
