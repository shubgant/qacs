using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // Another 'ConcreteDecorator'
    public class SteamedMilk : CondimentDecorator
    {
        private Beverage _beverage;

        public SteamedMilk(Beverage beverage) => _beverage = beverage;

        public override string Description
        {
            get => _beverage.Description + ", Steamed Milk";
        }

        public override decimal Cost
        {
            get => _beverage.Cost + 0.50m;
        }
    }
}
