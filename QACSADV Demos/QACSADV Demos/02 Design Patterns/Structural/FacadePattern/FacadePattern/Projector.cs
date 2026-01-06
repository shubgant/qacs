using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Subsystem Class 2
    public class Projector
    {
        public void On() => Console.WriteLine("Projector is on.");
        public void SetInputDvd(DvdPlayer dvd) => Console.WriteLine("Projector i/p set to DVD Player.");
        public void WideScreenMode() => Console.WriteLine("Projector set to widescreen mode.");
        public void Off() => Console.WriteLine("Projector is off.");
    }
}
