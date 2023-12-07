using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context
{
    
    abstract class Bird
    {
        //Instance variable
        IFlight flighttype;

        public Bird(IFlight flighttype)
        {
            this.flighttype = flighttype;
        }

        public string? Name { get; set; }
        public string? Color { get; set; }


        public void PerformFly()
        {
           
            flighttype.PerformFly();
        }

        
        public void SetPerformFly(IFlight flighttype)
        {
            this.flighttype = flighttype;
        }
    }
}
