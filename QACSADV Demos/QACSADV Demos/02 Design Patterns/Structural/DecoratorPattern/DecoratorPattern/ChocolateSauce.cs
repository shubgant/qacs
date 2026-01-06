using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // A 'ConcreteDecorator' class
    public class ChocolateSauce : CondimentDecorator
    {
        private Beverage _beverage;

        public ChocolateSauce(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description
        {
            get { 
                return _beverage.Description + ", Chocolate Sauce";
            }
        }

        public override decimal Cost
        {
            get
            {
                return _beverage.Cost + 0.40m;
            }
        }
    }
}
