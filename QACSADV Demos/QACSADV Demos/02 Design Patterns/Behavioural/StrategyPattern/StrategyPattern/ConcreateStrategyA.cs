using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{

    // A 'ConcreteStrategy' class implementing the strategy interface
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing strategy A");
    }
}
