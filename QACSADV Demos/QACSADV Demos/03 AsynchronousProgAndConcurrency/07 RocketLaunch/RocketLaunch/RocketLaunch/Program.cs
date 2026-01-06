
using System;
using System.Threading;
namespace RocketLaunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SequentialRocketPrep.PrepAndLaunchRocket();
            //AsyncRocketPrep.PrepAndLaunchRocket();
            BetterAsyncRocketPrep.PrepAndLaunchRocket();
            Console.ReadLine();
        }

    }
}
