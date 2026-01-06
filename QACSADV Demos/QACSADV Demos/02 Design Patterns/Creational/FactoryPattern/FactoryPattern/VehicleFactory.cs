using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // 'Creator' Abstract Class
    public abstract class VehicleFactory
    {
        // Factory Method
        public abstract Vehicle CreateVehicle();
    }
}
