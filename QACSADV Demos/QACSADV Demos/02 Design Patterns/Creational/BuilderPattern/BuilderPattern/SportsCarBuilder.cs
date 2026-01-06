using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SportsCarBuilder: CarBuilder
    {
        public SportsCarBuilder()
        {
            carType = CarType.Sports;
        }

        public override void BuildChassis()
        {
            car.Add("Sports Car Chassis");
        }

        public override void BuildEngine()
        {
            car.Add("1800 cc");
        }

        public override void BuildWheels()
        {
            car.Add("4 alloy wheels");
        }

        public override void BuildDoors()
        {
            car.Add("2 doors");
        }
    }
}
