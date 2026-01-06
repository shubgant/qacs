using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // 'ConcreteCreator' Class
    public class CarFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
