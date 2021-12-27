using System;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle airplay = new AirPlane(1129, "yellow", 11, 11);
            Vehicle test_car = new Car(222, "black", 4, "diesel");
            Garage<Vehicle> Garage_test = new(50);
            GarageHandler handler = new GarageHandler();
            var s = Garage_test.AddVehicle(airplay);
            var x = Garage_test.AddVehicle(test_car);
            Console.WriteLine(s);
            Console.WriteLine(x);
            //handler.PrintAllVehicles();

            //Garage_test[0] = airplay;
            Garage_test.GetVehicles();
            Console.WriteLine(Garage_test.GetVehicles());
            //handler.PrintAllVehicles();
            //setting values
            Console.WriteLine(Garage_test);
            Manager manager = new Manager();

            handler.Run(22);
            manager.Start();

        }
    }
}

