using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // The 'Context' class, which maintains a reference to the strategy object
    public class Context
    {
        private IStrategy _strategy;
        public Context(IStrategy strategy) => _strategy = strategy;
        public void SetStrategy(IStrategy strategy) => _strategy = strategy;
        public void ExecuteStrategy() => _strategy.Execute();
    }
}
