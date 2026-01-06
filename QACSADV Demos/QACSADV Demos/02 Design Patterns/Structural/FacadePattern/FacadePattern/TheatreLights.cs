using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{

    // Subsystem Class 3
    public class TheatreLights
    {
        public void Dim(int level) => Console.WriteLine($"Theatre lights dimmed to {level}%.");
        public void On() => Console.WriteLine("Theatre lights are on.");
    }

}
