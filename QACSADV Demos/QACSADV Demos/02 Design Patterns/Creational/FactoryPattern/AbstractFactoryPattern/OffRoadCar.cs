using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class OffRoadCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("An off-road car is bumping over rugged ground.");
        }
    }
}
