using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive(Vehicle vehicle)
        {
            Console.WriteLine($"The {vehicle.MainColor} Zero zips by you. {vehicle.VehicleNoises}");
        }
    }
}