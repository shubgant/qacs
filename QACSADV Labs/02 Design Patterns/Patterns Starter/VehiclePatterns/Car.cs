using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePatterns
{
    public class Car : IVehicle
    {
        // implement interface and add code to the DisplayStatus, StartEngine and StopEngine methods that output information to the console 
        // for example in the StartEngine method add Console.WriteLine("Car engine started");
        // also invoke the onchange event those 3 methods 
        //e.g. OnChange?.Invoke(this);

        public string Owner { get; set; }

        public Car(string Owner) {
            this.Owner = Owner;
        }

		public void DisplayStatus()
		{
			Console.WriteLine("Car status");
		}

        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }


    }
}
