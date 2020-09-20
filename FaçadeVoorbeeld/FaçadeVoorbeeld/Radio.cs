using System;
using System.Collections.Generic;
using System.Text;

namespace FaçadeVoorbeeld
{
    class Radio
    {
        public void On()
        {
            Console.WriteLine("Radio has been turned on");
        }
        public void Off()
        {
            Console.WriteLine("Radio has been turned off");
        }
        public void SetAM()
        {
            Console.WriteLine("Radio has been set to AM");
        }
        public void SetFM()
        {
            Console.WriteLine("Radio has been set to FM");

        }
        public void SetFrequency(Double freq)
        {
            Console.WriteLine($"Radio frequency has been set to {freq}");
        }
        public void LowerVolume()
        {
            Console.WriteLine("Radio volume has been lowered");
        }
        public void IncreaseVolume()
        {
            Console.WriteLine("Radio volume has been increased");
        }
    }
}
