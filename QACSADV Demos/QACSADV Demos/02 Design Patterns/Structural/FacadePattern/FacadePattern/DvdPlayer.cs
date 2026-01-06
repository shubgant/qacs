using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Subsystem Class 1
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player is on.");
        public void Play(string film) => Console.WriteLine($"Playing \"{film}\".");
        public void Off() => Console.WriteLine("DVD Player is off.");
    }
}
