﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal abstract class Vehicle
    {
        public int VehicleNumber { get; set; }
        public string? Brand { get; set; }
        public string? Model {  get; set; }
        public string? Type { get; set; }

        public abstract string? setTypeForVeh();
        public void Display()
        {
            Console.WriteLine(VehicleNumber+" "+Brand+" "+Model);
        }

    }
}
