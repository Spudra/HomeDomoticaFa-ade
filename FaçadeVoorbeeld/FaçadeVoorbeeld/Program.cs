using System;

namespace FaçadeVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Lights lights = new Lights();
            Gate gate = new Gate();
            Security security = new Security();
            Radio radio = new Radio();
            Curtain curtain = new Curtain();
            HomeDomoticaFaçade façade = new HomeDomoticaFaçade(heater, lights, gate, security, radio, curtain);
            façade.ArriveHome();
            Console.ReadLine();
            radio.SetFrequency(56.3);
            Console.ReadLine();
            security.CameraOff();
            Console.ReadLine();
            security.CameraOn();
            Console.ReadLine();
            façade.GoToBed();
            Console.ReadLine();
            façade.GetOutOfBed();
            Console.ReadLine();
            façade.LeaveHome();
        }
    }
}