using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Vehicle
    {
        public int RegisterNumber { get; set; }
        public string Color { get; set; }
        public int NumOfWheels { get; set; }

        public Vehicle(int registernumber,string color, int numofwheels)
        {
            RegisterNumber = registernumber;
            Color = color;
            NumOfWheels = numofwheels;
        }
        public virtual string Stats()
        {
            return $"The vehicle's Registernumber is {RegisterNumber}. It has color {Color} and has {NumOfWheels} number of wheels.";
        }
    }

    public class AirPlane: Vehicle
    {
        public int NumberOfEngines { get; set; }
        public AirPlane(int registernumber, string color, int numofwheels,int numberofengines) : base(registernumber, color, numofwheels)
        {
           NumberOfEngines = numberofengines;
        }
            
    }

    public class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }
        public Motorcycle(int registernumber, string color, int numofwheels, int cylinderVolume) : base(registernumber, color, numofwheels)
        {
            CylinderVolume = cylinderVolume;
        }

    }
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(int registernumber, string color, int numofwheels, string fueltype) : base(registernumber, color, numofwheels)
        {
            FuelType = fueltype;
        }

    }
    public class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public Bus(int registernumber, string color, int numofwheels, int numberofseats) : base(registernumber, color, numofwheels)
        {
            NumberOfSeats = numberofseats;
        }

    }
    public class Boat : Vehicle
    {
        public int Length { get; set; }
        public Boat(int registernumber, string color, int numofwheels, int length) : base(registernumber, color, numofwheels)
        {
            Length = length;
        }

    }

}
