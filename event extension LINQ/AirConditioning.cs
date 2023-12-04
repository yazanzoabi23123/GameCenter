using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_extension_LINQ
{
    internal class AirConditioning
    {
        public void OnTemperatureThresholdExceeded(object sender, EventArgs e)
        {
            Console.WriteLine("Turning on the air conditioner...");


        }
    }
}
