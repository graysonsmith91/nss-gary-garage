using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive(Vehicle vehicle)
        {
            Console.WriteLine($"The {vehicle.MainColor} Tesla zips by you. {vehicle.VehicleNoises}");
        }
    }
}