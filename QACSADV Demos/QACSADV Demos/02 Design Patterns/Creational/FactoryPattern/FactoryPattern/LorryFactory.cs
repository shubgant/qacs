using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // Another 'ConcreteCreator' Class
    public class LorryFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Lorry();
        }
    }
}
