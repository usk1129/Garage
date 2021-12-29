﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public interface IVehicle
    {
        string RegisterNumber { get; }
        string Color { get; }
        int NumOfWheels { get; }
    }
}
