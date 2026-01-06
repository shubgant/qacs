using System.Runtime;
using System.Runtime.CompilerServices;

namespace OutOfControlCS
{

    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            int threadCount = 10;

            Thread[] workers = new Thread[threadCount];

            //CancellationToken is recommended way of coordinating thread cancellation
            CancellationTokenSource cts = new CancellationTokenSource();

            for (int i = 0; i < threadCount; i++)
            {
                //OLD dangerous way of starting threads - approach works
                //But killing the threads is problematical
                //workers[i] = new Thread(new ThreadStart(OutOfControl));
                //workers[i].Start();

                // Change the name of the method being passed to the WaitCallBack constructor
                // to see the different behaviours of the classes
                ThreadPool.QueueUserWorkItem(new WaitCallback(OutOfControl), cts.Token);
                //ThreadPool.QueueUserWorkItem(new WaitCallback(InControl), cts.Token);
                //ThreadPool.QueueUserWorkItem(new WaitCallback(BetterInControl), cts.Token);
                //ThreadPool.QueueUserWorkItem(new WaitCallback(AlternativeInControl), cts.Token);
            }
            //Threads are all running hitting the enter key will stop them 
            Console.ReadLine();

            //Old obsolete and dangerous way to kill a thread 
            //for (int i = 0; i < threadCount; i++)
            //{
            //    workers[i].Abort();
            //}

            //More controlled apporach to coordinate the killing of threads
            cts.Cancel();

            Console.ReadLine();
        }

        //
        // OutOfControl() - expect garbled output
        //
        static void OutOfControl(object? obj)
        {
            if (obj is null)
                return;

            CancellationToken token = (CancellationToken)obj;

            for (; ; )
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                Console.Write("I ");
                Console.Write("love ");
                Console.Write("debugging ");
                Console.Write("multithreaded ");
                Console.Write("programs!");
                Console.WriteLine();
            }
        }


        //
        // InControl() - using Monitor to ensure synchronisation
        //               but it really should have a try {} finally{}
        //               to deal with exceptions
        //
        static void InControl(object? obj)
        {
            if (obj is null)
                return;

            CancellationToken token = (CancellationToken)obj;
            for (; ; )
            {
                Monitor.Enter(typeof(Class1));
                if (token.IsCancellationRequested)
                {
                    break;
                }

                Console.Write("I ");
                Console.Write("love ");
                Console.Write("debugging ");
                Console.Write("multithreaded ");
                Console.Write("programs!");
                Console.WriteLine();

                // But what happens if someone calls Abort(), or an
                // exception is thrown?
                // In this case, Exit() won't be called, which will leave
                // the sync object locked.
                // Isn't there something better?

                // Thread.CurrentThread.Abort();

                Monitor.Exit(typeof(Class1));
            }
        }

        //
        // BetterInControl() - Rather than add try{} finally{}, we
        // are using the lock() mechanism from C# to do it for us
        //
        static void BetterInControl(object? obj)
        {
            if (obj is null)
                return;

            CancellationToken token = (CancellationToken)obj;

            for (; ; )
            {
                lock (typeof(Class1))
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }
                    Console.Write("I ");
                    Console.Write("love ");
                    Console.Write("debugging ");
                    Console.Write("multithreaded ");
                    Console.Write("programs!");
                    Console.WriteLine();
                }
            }
        }

        //
        // AlternativeInControl() - goes a stage further, and uses a
        // helper method, WriteMessage(), that has an attribute to 
        // mark the call as requiring synchronisation
        //		
        static void AlternativeInControl(object? obj)
        {
            if (obj is null)
                return;

            CancellationToken token = (CancellationToken)obj;

            for (; ; )
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                WriteMessage();
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        static void WriteMessage()
        {
            Console.Write("I ");
            Console.Write("love ");
            Console.Write("debugging ");
            Console.Write("multithreaded ");
            Console.Write("programs!");
            Console.WriteLine();
        }


    }
}