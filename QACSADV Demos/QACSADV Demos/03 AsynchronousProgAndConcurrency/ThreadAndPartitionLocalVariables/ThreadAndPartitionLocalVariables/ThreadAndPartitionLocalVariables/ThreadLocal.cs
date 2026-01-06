using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAndPartitionLocalVariables
{
    public class ThreadLocal
    {
        // Declare a thread-local variable using ThreadLocal<T>
        static ThreadLocal<int> threadLocalCounter = new ThreadLocal<int>(() => 0);

        public static void Demo()
        {
            Console.WriteLine($"Final counter value (main thread id: {Thread.CurrentThread.ManagedThreadId}): {threadLocalCounter.Value}");

            // Use Parallel.For to create multiple threads to increment the thread-local counter
            Parallel.For(0, 5, i =>
            {
                // Increment the thread-local counter a random number of times
                Random r = new Random();
                int num = r.Next(1,10);
                for (int j=0;j<num;j++)
                    threadLocalCounter.Value++;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: incremented the counter {num} times: Counter value = {threadLocalCounter.Value}");
            });

            // Each thread has its own instance of the thread-local counter
            Console.WriteLine($"Final counter value (main thread id: {Thread.CurrentThread.ManagedThreadId}): {threadLocalCounter.Value}");

            // Dispose the ThreadLocal<T> instance
            threadLocalCounter.Dispose();

        }

    }


}
