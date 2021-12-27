using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class GarageHandler
    {
        private Garage<Vehicle> garage;
        public bool Run(int garageCapacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(garageCapacity);
            return true;
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            return garage.AddVehicle(vehicle);

        }
        internal void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle.Stats());
            }
        }
        public void hello()
        {
            Console.WriteLine("hello");
        }

    }
}