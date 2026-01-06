using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // A 'ConcreteComponent' class
    public class Espresso : Beverage
    {
        public override string Description { get; } = "Espresso";
        public override decimal Cost { get; } = 2.99m;
    }
}
