using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Another 'ConcreteStrategy' class
    public class ConcreteStrategyB : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing strategy B");
    }
}
