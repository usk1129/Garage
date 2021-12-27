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
                    var input2 = Console.ReadLine();
                    handler.Run(Int32.Parse(input2));
                    break;
                case "2":
                    //GarageHandler.ParkVehicle(VehicleChoice());
                    break;
                case "3":
                    //ViewCars();
                    break;
                case "4":
                    //PrintUndefined();
                    break;
                case "0":
                    ShutDown();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        private void ShutDown()
        {
            Console.WriteLine("Garage is shutting down! Bye bye!");
            Environment.Exit(0);
        }
    }
}
