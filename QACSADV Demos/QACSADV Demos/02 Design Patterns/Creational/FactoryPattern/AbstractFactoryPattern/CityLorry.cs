using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CityLorry : ILorry
    {
        public void LoadCargo()
        {
            Console.WriteLine("Cargo is being loaded into a SMALL, ELECTRIC city lorry.");
        }
    }
}
