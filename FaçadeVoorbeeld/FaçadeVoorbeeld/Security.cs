using System;
using System.Collections.Generic;
using System.Text;

namespace FaçadeVoorbeeld
{
    class Security
    {
        public void CameraOn()
        {
            Console.WriteLine("Security cameras have been turned on");
        }
        public void CameraOff()
        {
            Console.WriteLine("Security cameras have been turned off");
        }
        public void SensorsOn()
        {
            Console.WriteLine("Security sensors have been turned on");
        }
        public void SensorsOff()
        {
            Console.WriteLine("Security sensors have been turned off");
        }
        public void AlarmOn()
        {
            Console.WriteLine("Security alarm has been turned on");
        }
        public void AlarmOff()
        {
            Console.WriteLine("Security alarm has been turned off");
        }
    }
}