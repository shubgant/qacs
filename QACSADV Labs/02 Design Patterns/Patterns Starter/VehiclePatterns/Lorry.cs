using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePatterns
{
    public class Lorry : IVehicle
    {

        // implement interface and add code to the DisplayStatus, StartEngine and StopEngine methods that output information to the console 
        // for example in the StartEngine method add Console.WriteLine("Lorry engine started");
        // also invoke the onchange event those 3 methods 
        //e.g. OnChange?.Invoke(this);

        public string Owner { get; set; }
        public event Action<IVehicle>? OnChange;

        public Lorry(string Owner)
        {
            this.Owner = Owner;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Lorry status: owned by {Owner}");
            OnChange?.Invoke(this);
        }

        public void StartEngine()
        {
            Console.WriteLine("Lorry engine started");
            OnChange?.Invoke(this);
        }

        public void StopEngine()
        {
            Console.WriteLine("Lorry engine stopped");
            OnChange?.Invoke(this);
        }

        public void Add(IVehicle vehicle) { }
        public void Remove(IVehicle vehicle) { }
    }
}

