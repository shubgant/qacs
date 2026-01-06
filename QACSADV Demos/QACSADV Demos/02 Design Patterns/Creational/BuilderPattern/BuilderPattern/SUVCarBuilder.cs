using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SUVCarBuilder : CarBuilder
    {
        public SUVCarBuilder()
        {
            carType = CarType.SUV;
        }

        public override void BuildChassis()
        {
            car.Add("SUV Frame");
        }

        public override void BuildEngine()
        {
            car.Add("3000 cc");
        }

        public override void BuildWheels()
        {
            car.Add("4 large wheels");
        }

        public override void BuildDoors()
        {
            car.Add("4 doors");
        }

    }
}
