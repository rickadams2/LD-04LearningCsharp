﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassSolution
{
    class Car
    {
        public string make;
        public string model;
        public string color;

        public void Drive()
        {
            Console.WriteLine("Driving");

        }
        public void Stop()
        {
            Console.WriteLine("Stopping");
        }

    }
}
