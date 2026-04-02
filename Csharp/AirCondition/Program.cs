namespace AirCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare objects
            AirCondition aircondition = new AirCondition();
            Fan fan = new Fan();
            Thermostat thermostat = new Thermostat();

            //subscribe to thermostat
            thermostat.OnTemperatureRaised += fan.onTemperatureRaised;
            thermostat.OnTemperatureRaised += aircondition.onTemperatureRaised;

            //trigger event
            thermostat.RaiseTemperature();
            Console.WriteLine($"The air-condition status is {aircondition.power}");
            Console.WriteLine($"The fan status is {fan.power}");
        }
    }
}
