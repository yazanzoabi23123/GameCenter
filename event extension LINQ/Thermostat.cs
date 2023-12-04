using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_extension_LINQ
{
    internal class Thermostat
    {
        private float temperature;

        public delegate void TemperatureEventHandler(object sender, EventArgs args);
        public event TemperatureEventHandler TemperatureThresholdExceeded;

        public float Temperature
        {
            get { return temperature; }
            set
            {
                if (value > 30)  // Threshold set at 30 for this example
                    TemperatureThresholdExceeded?.Invoke(this, EventArgs.Empty);

                temperature = value;
            }
        }

    }
}
