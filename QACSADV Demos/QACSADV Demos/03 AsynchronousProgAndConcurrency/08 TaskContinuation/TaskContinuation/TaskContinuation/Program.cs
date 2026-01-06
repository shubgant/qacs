using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace TaskContinuation
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //string keyword = "distinction";
            string keyword = "perspiciatis";
            await BasicContinuation.Demo();
            await ConditionalTaskContinuation.Demo(keyword);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            Thread.Sleep(3000);
            Console.WriteLine("All Done!");
        }
    }
}
