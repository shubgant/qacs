using System.Threading;
using System.Threading.Tasks;

namespace RocketLaunch
{
    internal class BetterAsyncRocketPrep
    {
        public static async void PrepAndLaunchRocket()
        //------------^^^^^---------------------------
        {
            Console.WriteLine($"\nBetter Asynchronous Rocket Launch!");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Task taskSandwiches = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Sandwiches Made and Packed!");
            });

            Task<string> task1 = MoveRocketToLaunchpad();
            TidyUpAssemblyShed();//Main thread gets on with something else
            string padStatusMessage = await task1;
            Console.WriteLine( padStatusMessage );
            Task task2 = AddPayload();
            Task task3 = LoadOxygen();
            Task task4 = LoadHydrogen();
            //Don't forget the sandwiches
            taskSandwiches.Start();
            Task.WaitAll(task2, task3, task4, taskSandwiches);
            Task task5 = IgniteFuel();
            await task5;
            Task<string> task6 = BlastOff();
            string launchStatusMessage = await task6;
            Console.WriteLine(launchStatusMessage);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds}ms");
        }

        public static async Task<string> MoveRocketToLaunchpad()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("Rocket on Launchpad");
                return "Tractor returning to shed";
            });
        }

        public static void TidyUpAssemblyShed()
        {
            Console.WriteLine("Tidying up assemby shed...");
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

        public static async Task<string> BlastOff()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Rocket Launched!");
                return "Houston, We have a lift off!";
            });

        }
    }
}
