using System;
using System.Collections.Generic;
using System.Text;

namespace AirCondition
{
    public class AirCondition: IAirCondition
    {
        public bool power { get; set; } = false;
        public void TurnOn()
        {
            power = true;
        }
        public void onTemperatureRaised()
        {
            Console.WriteLine("I am AirCondition and I am turning on the machine");
            TurnOn();
        }
    }
}
