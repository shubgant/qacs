using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Manufacturer
    {
        //The 'Director' class
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.CreateNewCar();
            carBuilder.BuildChassis();
            carBuilder.BuildEngine();
            carBuilder.BuildWheels();
            carBuilder.BuildDoors();
        }
    }
}
