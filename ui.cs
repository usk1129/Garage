using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class ui
    {
        public void PrintUserChoices()
        {

            Console.WriteLine("--------------------------------");
            Console.WriteLine("\tWELCOME TO THE GARGE");
            Console.WriteLine("Use the menu to navigate");
            Console.WriteLine("Press 1: Create a new Garage");
            Console.WriteLine("Press 2: Park a new vehicle");
            Console.WriteLine("Press 3: Collect a parked vehicle");
            Console.WriteLine("Press 4: Show all parked vehicles");
            Console.WriteLine("Press 5: Show how many of each type of vehicle is parked in the garage");
            Console.WriteLine("Press 6: Search for vehicle by license plate");
            Console.WriteLine("Press 0: Exit the garage\n");
            Console.WriteLine("Enter your choice:");
        }
        


    }
}
