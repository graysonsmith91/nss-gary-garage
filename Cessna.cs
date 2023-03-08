using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive(Vehicle vehicle)
        {
            Console.WriteLine($"The {vehicle.MainColor} flies over you. {vehicle.VehicleNoises}");
        }

        public override void Stop()
        {
            Console.WriteLine("The plane comes to a gentle stop a mile down the runway after landing");
        }
    }
}