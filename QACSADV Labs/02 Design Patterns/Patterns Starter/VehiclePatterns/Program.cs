using System.Reflection.Metadata;

namespace VehiclePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~ Test 1");

            // Create and instnce of a VehicleFactory object
            VehicleFactory factory = new VehicleFactory();

            // use the factory object to assign vehicles to the correct type to the variables below
            string owner = "Shub";
            IVehicle car = factory.CreateVehicle(VehicleType.Car, owner);
            IVehicle lorry = factory.CreateVehicle(VehicleType.Lorry, owner);
            IVehicle motorcycle = factory.CreateVehicle(VehicleType.Motorcycle, owner);

            List<IVehicle> vehicles = new List<IVehicle>{ car, lorry, motorcycle };

            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.DisplayStatus();
                vehicle.StartEngine();
                vehicle.StopEngine();
            }

            // Create a VehicleGroup object and pass in the Owner in the constructor e.g. VehicleGroup("Bob's Used Vehicles");

            // Now add the three vehicles created earlier to the vehicle group 

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~ Test 2");

            VehicleGroup vehicleGroup = new VehicleGroup("Shub's Used Vehicles");

            foreach (IVehicle vehicle in vehicles)
            {
                vehicleGroup.Add(vehicle);
            }

            vehicleGroup.DisplayStatus();
            vehicleGroup.StartEngine();
            vehicleGroup.StopEngine();

            // Create an instance of the VehicleMonitor class

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~ Test 3");

            // Subsribe the update method on the monitor object to the OnChange event of the Vehicle group
            VehicleMonitor monitor = new VehicleMonitor();
            
            vehicleGroup.OnChange += monitor.Update;


            // Demonstrating functionality
            // call methods of the VehicleGroup object to Display Staus, start and stop engines, e.g.
            vehicleGroup.DisplayStatus();
            vehicleGroup.StartEngine();
            vehicleGroup.StopEngine();
        }
    }
}
