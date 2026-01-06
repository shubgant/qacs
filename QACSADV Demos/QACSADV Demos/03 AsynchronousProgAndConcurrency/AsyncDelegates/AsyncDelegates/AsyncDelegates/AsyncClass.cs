using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDelegates
{
    public class AsyncClass
    {
        //
        // Method that uses an asynchronous delegate, but which polls
        // using IsCompleted to see if the async delegate has finished
        // processing
        //
        internal void AsyncWithPolling()
        {

            Console.WriteLine("AsyncWithPolling");

            IAsyncResult iar;
            int res;

            // Create the new delegate
            Verbose v = new Verbose(BeVerbose);

            // Begin the call
            iar = v.BeginInvoke("Another Async Call", null, null);

            // Poll to see if the call has finished yet
            while (!iar.IsCompleted)
            {
                Console.WriteLine("Main thread still pumping");
                Thread.Sleep(0);
            }

            // Obtain the returned integer
            res = v.EndInvoke(iar);

            Console.WriteLine("Result was " + res);
            Console.ReadLine();

        }

        // Method that uses an asynchronous delegate, but which blocks
        // until the background task is finished - not a good idea if
        // you were using Windows Forms
        //
        internal void AsyncWithBlock()
        {

            Console.WriteLine("AsyncWithBlock");

            IAsyncResult iar;
            int res;

            // Create the new delegate
            Verbose v = new Verbose(BeVerbose);

            // Begin the call
            iar = v.BeginInvoke("Another Async Call", null, null);

            // Do a small amount of background work
            Console.WriteLine("Main thread about to block");

            // Block for the background thread
            iar.AsyncWaitHandle.WaitOne();

            // Obtain the returned integer
            res = v.EndInvoke(iar);

            Console.WriteLine("Result was " + res);
            Console.ReadLine();

        }


        internal void AsyncWithCallback()
        {

            Console.WriteLine("AsyncWithCallback");

            IAsyncResult iar;

            // Create the new delegate
            Verbose v = new Verbose(BeVerbose);

            // Begin the call, passing in the name of the method to call back to
            //iar = v.BeginInvoke("Another Async Call", new AsyncCallback(Callback), null);

            // Do a small amount of background work
            Console.WriteLine("Main thread about to block");

            Console.ReadLine();
        }

        //
        // Method that is called back to 
        // 
        //private void Callback(IAsyncResult iar)
        //{
        //    //
        //    // These two lines obtain the delegate
        //    //
        //    AsyncResult ar = (AsyncResult)iar;
        //    Verbose v = (Verbose)ar.AsyncDelegate;


        //    //
        //    // So that you can call EndInvoke
        //    //
        //    int res = v.EndInvoke(iar);
        //    Console.WriteLine("Result was " + res);
        //}

        //
        // Target function that does the work in the background
        //
        private int BeVerbose(string s)
        {
            Random r = new Random(Environment.TickCount);

            int limit = r.Next(10, 100);

            for (int i = 1; i < limit; i++)
            {
                Console.WriteLine(s);
                Thread.Sleep(0);
            }

            return limit;
        }

        private delegate int Verbose(string s);
    }
}
