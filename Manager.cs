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
            var input = ui.AskForStrInput("Enter your choice: ");

            switch (input)
            {
                case "1":
                    CreateGarage();
                    break;
                case "2":
                    if (handler.IsFull())
                    {
                        ui.PrintString("The garage is full");
                        break;
                    }
                    try
                    {
                        ParkVehicle();
                    }
                    catch (Exception ex)
                    {
                        ui.PrintString(ex.ToString());
                    }
                    break;
                case "3":
                    handler.PrintVehicles();
                    break;
                case "4":
                    UnParkVehicle();
                    break;
                case "5":
                    FindVehicle();
                    break;
                case "0":
                    ShutDown();
                    break;
                default:
                    ui.PrintString("Wrong input");
                    break;
            }
        }

        private bool FindVehicle()
        {
            var RegNumber = ui.AskForStrInput("Enter the register number");
            if (handler.FindVehicle(RegNumber))
            {
                return true;
            }
            else
            {
                ui.PrintString("The vehicle not found");
                return false;
            }
        }

        private void UnParkVehicle()
        {
            var RegisterNumber = ui.AskForStrInput("Enter the register number: ");
            if (handler.UnParkVehicle(RegisterNumber))
            {
                ui.PrintString("You're Vehicle has now been unparked.");
            }
            else
            {
                ui.PrintString("The Vehicle not found");
            }
            
        }

        private void ParkVehicle()
        {
            ui.VehicleType();
            var VehicleInput = ui.AskForStrInput("What kind of vehicle do you have?");
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
            var RegNumber = ui.AskForStrInput("Enter the register number: ");
            var Color = ui.AskForStrInput("What is the color?");
            var NumOFWheels = ui.AskForIntInput("Enter the Number of Wheels: ");
            var ExtProperty = ui.AskForStrInput("Enter the  Length");
            Boat car_vehicle = new(RegNumber, Color, NumOFWheels, Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            ui.PrintString("The vehicle has now been parked in the garage");
        }

        private void Bus()
        {
            var RegNumber = ui.AskForStrInput("Enter the register number: ");
            var Color = ui.AskForStrInput("What is the color?");
            var NumOFWheels = ui.AskForIntInput("Enter the Number of Wheels: ");
            var ExtProperty = ui.AskForStrInput("Enter the number of seats");
            Bus car_vehicle = new(RegNumber, Color, NumOFWheels, Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            ui.PrintString("The vehicle has now been parked in the garage");
        }

        private void Motorcycle()
        {
            var RegNumber = ui.AskForStrInput("Enter the register number: ");
            var Color = ui.AskForStrInput("What is the color?");
            var NumOFWheels = ui.AskForIntInput("Enter the Number of Wheels: ");
            var ExtProperty = ui.AskForStrInput("Enter the CylinderVolume");
            Motorcycle car_vehicle = new(RegNumber, Color, NumOFWheels, Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            ui.PrintString("The vehicle has now been parked in the garage");
        }

        private void AirPlane()
        {

            var RegNumber = ui.AskForStrInput("Enter the register number: ");
            var Color = ui.AskForStrInput("What is the color?");
            var NumOFWheels = ui.AskForIntInput("Enter the Number of Wheels: ");
            var ExtProperty = ui.AskForStrInput("Enter the NumberOfEngines: ");
            AirPlane car_vehicle = new(RegNumber, Color, NumOFWheels, Int32.Parse(ExtProperty));
            handler.ParkVehicle(car_vehicle);
            ui.PrintString("The vehicle has now been parked in the garage");
        }

        private void CarPark()
        {
            var RegNumber = ui.AskForStrInput("Enter the register number: ");
            var Color = ui.AskForStrInput("What is the color?");
            var NumOFWheels = ui.AskForIntInput("Enter the Number of Wheels: ");
            var ExtProperty = ui.AskForStrInput("Enter the fueltype");
            Car car_vehicle = new(RegNumber, Color, NumOFWheels, ExtProperty);
            handler.ParkVehicle(car_vehicle);
            ui.PrintString("The vehicle has now been parked in the garage");
        }

        private void CreateGarage()
        {
            var input_Capacity = ui.AskForIntInput("Enter the size of garage: ");
            handler.Run(input_Capacity);
            ui.PrintString($"Your garage has been created with {input_Capacity} slots");
        }

        private void ShutDown()
        {
            ui.PrintString("Garage is shutting down! Bye bye!");
            Environment.Exit(0);
        }
    }
}
