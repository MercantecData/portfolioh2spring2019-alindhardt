using Delegates.MyEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Television
    {
        public Television(string modelName, string manufacturer)
        {
            ModelName = modelName;
            Manufacturer = manufacturer;


        }

        public string ModelName { get; private set; }
        public string Manufacturer { get; private set; }
        public PowerState PowerState { get; private set; }
        public Controller Controller1 { get; private set; }

        public void PowerButtonPressed()
        {
            switch (PowerState)
            {
                case PowerState.Off:
                    PowerState = PowerState.On;
                    break;
                case PowerState.On:
                    PowerState = PowerState.Sleep;
                    break;
                case PowerState.Sleep:
                    PowerState = PowerState.On;
                    break;
            }
        }
    }
}
