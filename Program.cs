using System;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarageHandler handler = new GarageHandler();
            Garage<Vehicle> garage_test = new(20);
            Manager manager = new Manager();
            handler.Run(22);
            handler.Seeddata();
            handler.PrintVehicles();
            manager.Start();
        }
    }
}

