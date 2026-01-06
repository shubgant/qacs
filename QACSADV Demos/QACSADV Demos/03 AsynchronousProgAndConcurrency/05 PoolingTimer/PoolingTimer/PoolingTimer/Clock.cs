using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolingTimer
{
    internal class Clock
    {
        Timer t = null;
        int id = 0;

        internal void Start()
        {
            // Create the new timer object
            t = new Timer(new TimerCallback(DisplayTimer), null, 0, 1000);
        }

        internal void Stop()
        {
            if (t != null)
            {
                t.Dispose();
            }
        }

        internal void DisplayTimer(object o)
        {
            if (id == 0)
                id = AppDomain.GetCurrentThreadId();

            lock (this)
            {
                if (id != AppDomain.GetCurrentThreadId())
                {
                    id = AppDomain.GetCurrentThreadId();
                    Console.Write("\n");
                }
            }

            Console.Write("\r[Thread ID:{0}] {1:T}", AppDomain.GetCurrentThreadId(), System.DateTime.Now);

            // Uncomment this line to see how the threadpool will be used
            // to deliver multiple timer callbacks if one gets snagged
            // up. Note that if you make the delay more than the thread pool max, then
            // you'll run out of threads in the pool, which will result
            // in a big delay
             Thread.Sleep( 15000 );
        }
    }
}
