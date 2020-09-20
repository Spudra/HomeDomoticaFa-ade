using System;
using System.Collections.Generic;
using System.Text;

namespace FaçadeVoorbeeld
{
    class HomeDomoticaFaçade
    {
        private Heater heater { get; set; }
        private Lights lights { get; set; }
        private Gate gate { get; set; }
        private Security security { get; set; }
        private Radio radio { get; set; }
        private Curtain curtain { get; set; }

        public HomeDomoticaFaçade(Heater heater, Lights lights, Gate gate, Security security, Radio radio, Curtain curtain)
        {
            this.heater = heater;
            this.lights = lights;
            this.gate = gate;
            this.security = security;
            this.radio = radio;
            this.curtain = curtain;
        }

        public void ArriveHome()
        {
            Console.WriteLine("Arriving at home...");
            gate.OpenTemporary();
            security.AlarmOff();
            security.SensorsOff();
            lights.RegularLightsOn();
            heater.IncreaseTemp();
            radio.On();
            gate.OpenTemporary();
        }
        public void LeaveHome()
        {
            Console.WriteLine("Leaving home...");
            gate.OpenTemporary();
            lights.RegularLightsOff();
            heater.DecreaseTemp();
            radio.Off();
            security.AlarmOn();
            security.SensorsOn();
        }
        public void GoToBed()
        {
            Console.WriteLine("Going at bed...");
            lights.RegularLightsOff();
            lights.NightLampOn();
            curtain.Close();
            radio.Off();
            security.SensorsOn();
            heater.DecreaseTemp();
        }
        public void GetOutOfBed()
        {
            Console.WriteLine("Getting out of bed...");
            lights.NightLampOff();
            heater.IncreaseTemp();
            security.SensorsOff();
            curtain.Open();
        }
    }
}
