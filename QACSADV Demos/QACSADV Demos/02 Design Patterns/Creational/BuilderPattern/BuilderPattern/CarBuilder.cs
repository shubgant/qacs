using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // The 'Builder' abstract class
    public abstract class CarBuilder
    {
        protected CarType carType { get; init;  }
        protected Car car;
        public Car GetCar() =>  car;
        public void CreateNewCar() => 
            car = new Car() {Type = carType};
        public abstract void BuildChassis();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
