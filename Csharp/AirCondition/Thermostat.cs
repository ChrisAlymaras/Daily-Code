using System;
using System.Collections.Generic;
using System.Text;

namespace AirCondition
{
    public class Thermostat
    {
        public delegate void TemperatureRaisedEventHandler();
        public event TemperatureRaisedEventHandler? OnTemperatureRaised;

        public void RaiseTemperature()
        {
            Console.WriteLine("This is thermostat I am opening the Air Condition");
            OnTemperatureRaised?.Invoke();
        }
    }
}
