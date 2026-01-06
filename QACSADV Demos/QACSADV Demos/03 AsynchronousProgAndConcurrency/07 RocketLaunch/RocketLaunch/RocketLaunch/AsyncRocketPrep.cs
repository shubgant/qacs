using System.Threading;
using System.Threading.Tasks;

namespace RocketLaunch
{
    internal class AsyncRocketPrep
    {
        public static void PrepAndLaunchRocket()
        {
            Console.WriteLine($"\nAsynchronous Rocket Launch!");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Task task1 = MoveRocketToLaunchpad();
            Task task2 = AddPayload();
            Task task3 = LoadOxygen();
            Task task4 = LoadHydrogen();
            Task task5 = IgniteFuel();
            Task task6 = BlastOff();

            Task.WaitAll(task1, task2, task3, task4, task5, task6);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");
        }

        public static async Task MoveRocketToLaunchpad()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("Rocket on Launchpad");
            });
        }

        public static async Task AddPayload()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Payload Added");
            });
        }

        public static async Task LoadOxygen()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Oxygen Fueling Complete");
            });
        }

        public static async Task LoadHydrogen()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Hydrogen Fueling Complete");
            });
        }


        public static async Task IgniteFuel()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Fuel Ignited");
            });

        }

        public static async Task BlastOff()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Rocket Launched!");
            });
        }
    }
}
