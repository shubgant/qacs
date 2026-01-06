using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePatterns
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            // replace the statement below with code that returns a vehicle based on the vehicle type passed in the string parameter
            return vehicleType switch
            {
                VehicleType.Car => new Car("Shub"),
                VehicleType.Lorry => new Lorry("Shub"),
                VehicleType.Motorcycle => new MotorCycle("Shub"),
                _ => throw new ArgumentException("Unknown vehicle type")
            };
        }
    }

}
