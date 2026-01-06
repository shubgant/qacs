using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class ConcretePrototype : IPrototype
    {
        public int Age { get; set; }
        public string Name { get; set; }

        // Constructor for initializing data
        public ConcretePrototype(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Copy Constructor for deep copying
        public ConcretePrototype(ConcretePrototype prototype)
        {
            Name = prototype.Name;
            Age = prototype.Age;
        }
        // Cloning method
        public IPrototype Clone() => new ConcretePrototype(this);
        public void DisplayInfo() => Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
