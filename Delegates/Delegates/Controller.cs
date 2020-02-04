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

            Buttons = new Button[]
            {
                new Button("Power"),
                new Button("Volume Up"),
                new Button("Volume Down"),
                new Button("Channel Up"),
                new Button("Channel Down")
            };
        }

        public string ModelName { get; private set; }
        public string Manufacturer { get; private set; }
        public Button[] Buttons { get; private set; }
    }
}
