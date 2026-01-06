using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SaloonCarBuilder: CarBuilder
    {
        public SaloonCarBuilder()
        {
            carType = CarType.Saloon;
        }

        public override void BuildChassis()
        {
            car.Add("Saloon Chassis");
        }

        public override void BuildEngine()
        {
            car.Add("1600 cc");
        }

        public override void BuildWheels()
        {
            car.Add("4 wheels");
        }

        public override void BuildDoors()
        {
            car.Add("4 doors");
        }
    }
}
