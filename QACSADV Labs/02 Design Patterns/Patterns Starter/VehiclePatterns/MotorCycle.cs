using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace VehiclePatterns
    {
        public class MotorCycle : IVehicle
        {
            // implement interface and add code to the DisplayStatus, StartEngine and StopEngine methods that output information to the console 
            // for example in the StartEngine method add Console.WriteLine("Motorcycle engine started");
            // also invoke the onchange event those 3 methods 
            //e.g. OnChange?.Invoke(this);

            public string Owner { get; set; }
            public event Action<IVehicle>? OnChange;

            public MotorCycle(string Owner)
            {
                this.Owner = Owner;
            }

            public void DisplayStatus()
            {
                Console.WriteLine($"Motorcycle status: owned by {Owner}");
                OnChange?.Invoke(this);
            }

            public void StartEngine()
            {
                Console.WriteLine("Motorcycle engine started");
            OnChange?.Invoke(this);
        }

            public void StopEngine()
            {
                Console.WriteLine("Motorcycle engine stopped");
            OnChange?.Invoke(this);

        }
            public void Add(IVehicle vehicle) { }
            public void Remove(IVehicle vehicle) { }

    }
}

