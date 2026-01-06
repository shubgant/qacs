using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePatterns
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(VehicleType vehicleType, string owner)
        {
            // replace the statement below with code that returns a vehicle based on the vehicle type passed in the string parameter
            return vehicleType switch
            {
                VehicleType.Car => new Car(owner),
                VehicleType.Lorry => new Lorry(owner),
                VehicleType.Motorcycle => new MotorCycle(owner),
                _ => throw new ArgumentException("Unknown vehicle type")
            };
        }
    }

}
