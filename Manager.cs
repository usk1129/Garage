using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Garage
{
    public class Manager
    {
        private GarageHandler handler;
        readonly ui ui = new();

        public Manager()
        {
            handler = new GarageHandler();

        }
        public void Start()
        {
            int userchoice;
            ui.Initiliaze();
            CreateGarage();
            while (true)
            {
                ui.PrintUserChoices();
                UserInput();
            }
        }
        public void UserInput()
        {
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGarage();
                    break;
                case "2":
                    if (handler.IsFull())
                    {
                        Console.WriteLine("The garage is full");
                        break;
                    }
                    try
                    {
                        ParkVehicle();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case "3":
                    handler.PrintVehicles();
                    break;
                case "4":
                    UnParkVehicle();
                    break;
                case "0":
                    ShutDown();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }

        private void UnParkVehicle()
        {
            Console.WriteLine("Enter youre register number");
            var RegisterNumber = Console.ReadLine();
            handler.UnParkVehicle(RegisterNumber);
            Console.WriteLine("You're Vehicle has now been unparked.");
        }

        private void ParkVehicle()
        {
            Console.WriteLine("What kind of vehicle do you have?");
            ui.VehicleType();
            var VehicleInput = Console.ReadLine();
            switch (VehicleInput)
            {
                case "1":
                    CarPark();
                    break;
                case "2":
                    AirPlane();
                    break;
                case "3":
                    Motorcycle();
                    break;
                case "4":
                    Bus();
                    break;
                case "5":
                    Boat();
                    break;
                default:
                    break;
            }
        }

        private void Boat()
        {
            Console.WriteLine("Enter the register number: ");
            var RegNumber = Console.ReadLine();
            Console.WriteLine("What is the color?");
            var Color = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheels: ");
            var NumOFWheels = Console.ReadLine();
            Console.WriteLine("Enter the  Length");
            var ExtProperty = Console.ReadLine();
            Boat car_vehicle = new(RegNumber, Color, Int32.Parse(NumOFWheels), Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            Console.WriteLine("The vehicle has now been parked in the garage");
        }

        private void Bus()
        {
            Console.WriteLine("Enter the register number: ");
            var RegNumber = Console.ReadLine();
            Console.WriteLine("What is the color?");
            var Color = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheels: ");
            var NumOFWheels = Console.ReadLine();
            Console.WriteLine("Enter the number of seats");
            var ExtProperty = Console.ReadLine();
            Bus car_vehicle = new(RegNumber, Color, Int32.Parse(NumOFWheels), Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            Console.WriteLine("The vehicle has now been parked in the garage");
        }

        private void Motorcycle()
        {
            Console.WriteLine("Enter the register number: ");
            var RegNumber = Console.ReadLine();
            Console.WriteLine("What is the color?");
            var Color = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheels: ");
            var NumOFWheels = Console.ReadLine();
            Console.WriteLine("Enter the CylinderVolume");
            var ExtProperty = Console.ReadLine();
            Motorcycle car_vehicle = new(RegNumber, Color, Int32.Parse(NumOFWheels), Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            Console.WriteLine("The vehicle has now been parked in the garage");
        }

        private void AirPlane()
        {
            Console.WriteLine("Enter the register number: ");
            var RegNumber = Console.ReadLine();
            Console.WriteLine("What is the color?");
            var Color = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheels: ");
            var NumOFWheels = Console.ReadLine();
            Console.WriteLine("Enter the NumberOfEngines: ");
            var ExtProperty = Console.ReadLine();
            AirPlane car_vehicle = new(RegNumber, Color, Int32.Parse(NumOFWheels), Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            Console.WriteLine("The vehicle has now been parked in the garage");
        }

        private void CarPark()
        {
            Console.WriteLine("Enter the register number: ");
            var RegNumber = Console.ReadLine();
            Console.WriteLine("What is the color?");
            var Color = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheels: ");
            var NumOFWheels = Console.ReadLine();
            Console.WriteLine("Enter the fueltype");
            var ExtProperty = Console.ReadLine();
            Car car_vehicle = new(RegNumber, Color, Int32.Parse(NumOFWheels), ExtProperty);
            handler.ParkVehicle(car_vehicle);
            Console.WriteLine("The vehicle has now been parked in the garage");
        }

        private void CreateGarage()
        {
            Console.WriteLine("Enter the size of garage: ");
            var input_Capacity = Console.ReadLine();
            handler.Run(Int32.Parse(input_Capacity));
            Console.WriteLine($"Your garage has been created with {input_Capacity} slots");
        }

        private void ShutDown()
        {
            Console.WriteLine("Garage is shutting down! Bye bye!");
            Environment.Exit(0);
        }
    }
}
