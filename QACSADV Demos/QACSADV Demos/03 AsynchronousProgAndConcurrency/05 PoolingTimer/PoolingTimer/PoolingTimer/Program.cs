namespace PoolingTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clk = new Clock();
            int tpt = 0;
            int wtpt = 0;
            ThreadPool.GetMaxThreads(out tpt, out wtpt);
            Console.WriteLine($"TPT: {tpt}, WTPT: {wtpt}");
            //Limit thread pool to 10 threads
            ThreadPool.SetMaxThreads(10, 10);
            ThreadPool.GetMaxThreads(out tpt, out wtpt);
            Console.WriteLine($"TPT: {tpt}, WTPT: {wtpt}");
            Console.WriteLine("[Thread ID:{0}]", Thread.CurrentThread.ManagedThreadId); // AppDomain.GetCurrentThreadId());

            clk.Start();

            Console.ReadLine();

            clk.Stop();
        }
    }
}
