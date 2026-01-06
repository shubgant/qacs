using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CityCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("A city car is on the move on a metalled road.");
        }
    }
}
