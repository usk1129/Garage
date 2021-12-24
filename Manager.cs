using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Manager
    {
        ui ui;

        public Manager()
        {
            ui = new ui();
            GarageHandler garageHandler = new GarageHandler();
        }

        public void Start()
        {
            while (true)
            {
                ui.PrintUserChoices();
                ui.UserInput();
            }
        }
    }
}
