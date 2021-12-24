using System;

namespace Garage
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Vehicle airplay = new AirPlane(1129, "yellow", 11, 11);
            Garage<Vehicle> Garage_test = new(50);
            //Garage_test[0] = airplay;
            Garage_test.GetVehicles();
            Console.WriteLine(Garage_test.GetVehicles());
            //setting values
            Console.WriteLine(Garage_test);
            Console.WriteLine();
            Manager manager = new Manager();
            manager.Start();
            
        }




    }
}

