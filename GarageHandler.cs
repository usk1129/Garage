using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class GarageHandler
    {
        public void Run(int garageCapacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(garageCapacity);
        }
    }
}