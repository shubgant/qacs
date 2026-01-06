using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // 'ConcreteProduct' Class
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
