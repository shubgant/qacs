using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class EstateCarBuilder: CarBuilder
    {
        public EstateCarBuilder() => carType = CarType.Estate;

        public override void BuildChassis() => car.Add("Estate Chassis");
        public override void BuildEngine() => car.Add("2000 cc");
        public override void BuildWheels() => car.Add("4 wheels");
        public override void BuildDoors() => car.Add("5 doors");
    }
}
