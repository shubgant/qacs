using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OberverVSDelegate
{
    internal class ConcreteObserver : IObserver
    {
        private readonly string name;

        public ConcreteObserver(string name) => this.name = name;

        public void Update(int newState)
        {
            Console.WriteLine($"Observer {name} received update: State is now {newState}");
        }
    }
}
