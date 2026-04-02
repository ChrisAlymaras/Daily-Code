using System;
using System.Collections.Generic;
using System.Text;

namespace AirCondition
{
    public class Fan: IAirCondition
    {
        public bool power { get; set; } = false;
        public void TurnOn()
        {
            power = true;
        }
        public void onTemperatureRaised()
        {
            Console.WriteLine("I am Fan and I am turning on the fan");
            TurnOn();
        }
    }
}
