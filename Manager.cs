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
                    ParkVehicle();
                    break;
                case "3":
                    handler.PrintVehicles();
                    break;
                case "4":
                //    UnParkVehicle();
                    break;
                case "0":
                    ShutDown();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }

 

        private void ParkVehicle()
        {
            Console.WriteLine("Enter you're vehicle in order: ");
            Console.WriteLine("Enter the register number: ");
            var RegNumber = Console.ReadLine();
            Console.WriteLine("What is the color?");
            var Color = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheels: ");
            var NumOFWheels = Console.ReadLine();
            Console.WriteLine("Enter the fueltype");
            var ExtProperty = Console.ReadLine();
            Car car_vehicle = new(RegNumber,Color,Int32.Parse(NumOFWheels),ExtProperty);
            handler.ParkVehicle(car_vehicle);
        }

        private void CreateGarage()
        {
            Console.WriteLine("Enter the size of garage: ");
            var input = Console.ReadLine();
            handler.Run(Int32.Parse(input));
        }

        private void ShutDown()
        {
            Console.WriteLine("Garage is shutting down! Bye bye!");
            Environment.Exit(0);
        }
    }
}
