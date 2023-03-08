using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Tesla myModelS = new Tesla();
            Ram myRam = new Ram();
            Cessna myAirplane = new Cessna();
            Zero myFx = new Zero();

            myModelS.MainColor = "Dark Purple";
            myRam.MainColor = "Pitch Black";
            myAirplane.MainColor = "Hot Pink";
            myFx.MainColor = "Midnight Blue";

            myModelS.VehicleNoises = "ZzzzZZZzzzz";
            myRam.VehicleNoises = "GRRRRRRRR!";
            myAirplane.VehicleNoises = "Whoooooooooosh!";
            myFx.VehicleNoises = "Pewwwwwww";

            myModelS.Drive(myModelS);
            myModelS.Turn("left");
            myModelS.Stop();
            Console.WriteLine();

            myRam.Drive(myRam);
            myRam.Turn("right");
            myRam.Stop();
            Console.WriteLine();

            myFx.Drive(myFx);
            myFx.Turn("left");
            myFx.Stop();
            Console.WriteLine();

            myAirplane.Drive(myAirplane);
            myAirplane.Turn("right");
            myAirplane.Stop();
            Console.WriteLine();

        }
    }
}
