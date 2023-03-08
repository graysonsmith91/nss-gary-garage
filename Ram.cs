using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive(Vehicle vehicle)
        {
            Console.WriteLine($"The {vehicle.MainColor} Ram growls past you. {vehicle.VehicleNoises}");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle screeches loudly as it skids to the {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle crashes into a tree");
        }
    }
}