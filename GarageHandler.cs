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
        internal bool IsFull() => garage!.MaxCapacity();
        public bool Run(int garageCapacity)
        {
            garage = new Garage<Vehicle>(garageCapacity);
            return true;
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            return garage.AddVehicle(vehicle);
        }

        public bool UnParkVehicle(String RegNo)
        {
            return garage.RemoveVehicle(RegNo);
        }

        public bool FindVehicle(string RegNo)
        {
            return garage.FindVehicle(RegNo);
        }

        public void PrintVehicles()
        {
           
            foreach (var v in garage)
            {
                Console.WriteLine(v.Stats());
            }
        }

        public void Seeddata()
        {
            Vehicle airplay = new AirPlane("1111", "yellow", 11, 11);
            Vehicle test_car = new Car("222", "black", 4, "diesel");
            Vehicle test_car2 = new Car("2224", "blacssk", 1, "bensinl");
            garage.AddVehicle(airplay);
            garage.AddVehicle(test_car);
            garage.AddVehicle(test_car2);
            garage.RemoveVehicle(test_car.RegisterNumber);
        }

        public void PrintVehiclesObj()
        {
            var nrofCar = 0;
            var nrofAirPlane = 0;
            var nrofMotorCycle = 0;
            var nrofBus = 0;
            var nrofBoat = 0;
            foreach (var v in garage)
            {
                if(v.GetType().Name == "Car")
                {
                    nrofCar++;
                }
                if (v.GetType().Name == "AirPlane")
                {
                    nrofAirPlane++;
                }
                if (v.GetType().Name == "Motorcycle")
                {
                    nrofMotorCycle++;
                }
                if (v.GetType().Name == "Bus")
                {
                    nrofBus++;
                }
                if (v.GetType().Name == "Boat")
                {
                    nrofBoat++;
                }
            }

            Console.WriteLine("Total amount of parked car is " + nrofCar);
            Console.WriteLine("Total amount of parked AirPlane is " + nrofAirPlane);
            Console.WriteLine("Total amount of parked Motorcycle is " + nrofMotorCycle);
            Console.WriteLine("Total amount of parked Bus is " + nrofBus);
            Console.WriteLine("Total amount of parked Boat is " + nrofBoat);
        }


    }
}