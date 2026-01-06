namespace ThreadingIsEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Creating a multi-threaded application is EASY...");
            //
            // Create the ThreadStart delegate and connect it to the
            // DoSomething method, then instantiate the Thread object
            //
            ThreadStart ts = new ThreadStart(DoSomething);
            Thread worker = new Thread(ts);
            worker.IsBackground = true;
            worker.Start();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();

            // more to come here
            Console.Write("\n...But Debugging it is HARD");
        }

        private static void DoSomething()
        {
            // ...
            while (true)
            {
                Console.Write(DateTime.Now.ToLongTimeString() + "\r");
            }
        }
    }
}
