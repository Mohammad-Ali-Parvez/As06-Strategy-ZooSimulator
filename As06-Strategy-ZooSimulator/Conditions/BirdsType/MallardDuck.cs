using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooSimulator.Strategy;

namespace ZooSimulator.Context.BirdsType
{
    
    internal class MallardDuck : Bird
    {
        
        public MallardDuck(IFlight flighttype) : base(flighttype)
        {
        }
        public static void Quack()
        {
            Console.WriteLine("Quack");
        }
        public static void Swim()
        {
            Console.WriteLine("Swims perfectly!");
        }
    }
}
