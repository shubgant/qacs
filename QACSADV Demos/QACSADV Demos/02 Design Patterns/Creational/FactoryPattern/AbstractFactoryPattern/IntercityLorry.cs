using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class IntercityLorry : ILorry
    {
        public void LoadCargo()
        {
            Console.WriteLine("Loading cargo into a LARGE, DIESEL intercity truck.");
        }
    }
}
