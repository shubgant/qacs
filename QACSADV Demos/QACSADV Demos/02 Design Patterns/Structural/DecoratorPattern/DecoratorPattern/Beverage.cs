using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // The 'Component' abstract class
    public abstract class Beverage
    {
        public abstract string Description { get;  }
        public abstract decimal Cost { get;   }
    }
}
