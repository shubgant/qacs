using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CityVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new CityCar();
        }

        public ILorry CreateLorry()
        {
            return new CityLorry();
        }

    }
}
