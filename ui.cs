using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class ui: IUI
    {
        public void PrintUserChoices()
        {

            PrintString("--------------------------------");
            PrintString("\tWELCOME TO THE GARGE");
            PrintString("Use the menu to navigate");
            PrintString("Press 1: Create a new Garage");
            PrintString("Press 2: Park a new vehicle");
            PrintString("Press 3: Show all parked vehicles");
            PrintString("Press 4: Unpark a vehicle by RegisterNumber");
            PrintString("Press 5: Show how many of each type of vehicle is parked in the garage");
            PrintString("Press 6: Search for vehicle by license plate");
            PrintString("Press 0: Exit the garage\n");
         

        }

        internal void Initiliaze()
        {
            PrintString("What size do you want you're garage?");
        }

        internal void VehicleType()
        {
            PrintString("Enter you're type of vehicle");
            PrintString("Enter 1 for Car: ");
            PrintString("Enter 2 for Airplane: ");
            PrintString("Enter 3 for MotorCycle: ");
            PrintString("Enter 4 for Bus: ");
            PrintString("Enter 5 for Boat: ");
        }
        public string AskForStrInput(string prompt)
        {
            bool success = false;
            string answer;

            do
            {
                PrintString($"{prompt} ");
                answer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    PrintString($"You must enter a {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }


        public int AskForIntInput(string prompt)
        {
            do
            {
                string input = AskForStrInput(prompt);
                if (int.TryParse(input, out int answer)) return answer;

            } while (true);
        }


        public void PrintString(string message)
        {
            Console.WriteLine(message);
        }
    }
}
