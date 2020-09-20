using System;
using System.Collections.Generic;
using System.Text;

namespace FaçadeVoorbeeld
{
    class Lights
    {
        public void RegularLightsOn()
        {
            Console.WriteLine("Regular lights have been turned on");
        }
        public void RegularLightsOff()
        {
            Console.WriteLine("Regular lights have been turned off");
        }
        public void NightLampOn()
        {
            Console.WriteLine("Night lamp has been turned on");
        }
        public void NightLampOff()
        {
            Console.WriteLine("Night lamp has been turned off");
        }
    }
}
