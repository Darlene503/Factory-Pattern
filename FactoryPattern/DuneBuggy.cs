﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DuneBuggy : IVehicle
    {
        public  DuneBuggy()
        {
        }
        
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("This is fun");
        }


    }
}
