﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.BirdsType
{
    internal class Penguin : Bird
    {
       
        public Penguin(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Walks()
        {
            Console.WriteLine("Walks.");
        }
    }
}
