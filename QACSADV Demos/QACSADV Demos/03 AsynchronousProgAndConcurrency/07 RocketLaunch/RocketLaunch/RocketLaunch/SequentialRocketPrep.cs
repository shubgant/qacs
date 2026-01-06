using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLaunch
{
    internal class SequentialRocketPrep
    {
        public static void PrepAndLaunchRocket()
        {
            Console.WriteLine($"\nSequential Rocket Launch!");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            MoveRocketToLaunchpad();
            AddPayload();
            LoadOxygen();
            LoadHydrogen();
            IgniteFuel();
            BlastOff();
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");
        }

        public static void MoveRocketToLaunchpad()
        {
            Thread.Sleep(8000);
            Console.WriteLine("Rocket on Launchpad");
        }

        public static void AddPayload()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Payload Added");
        }

        public static void LoadOxygen()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Oxygen Fueling Complete");
        }
        public static void LoadHydrogen()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Hydrogen Fueling Complete");
        }

        public static void IgniteFuel()
        {
            Thread.Sleep(500);
            Console.WriteLine("Fuel Ignited");

        }

        public static void BlastOff()
        {
            Thread.Sleep(500);
            Console.WriteLine("Rocket Launched!");
        }
    }
}
