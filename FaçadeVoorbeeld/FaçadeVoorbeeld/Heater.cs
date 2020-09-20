using System;
using System.Collections.Generic;
using System.Text;

namespace FaçadeVoorbeeld
{
    class Heater
    {
        public void IncreaseTemp()
        {
            Console.WriteLine("The temperature of the heater has been increased");
        }
        public void DecreaseTemp()
        {
            Console.WriteLine("The temperature of the heater has been decreased");
        }
    }
}
