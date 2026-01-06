using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // Another 'ConcreteProduct' Class
    public class Lorry : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a lorry");
        }
    }
}
