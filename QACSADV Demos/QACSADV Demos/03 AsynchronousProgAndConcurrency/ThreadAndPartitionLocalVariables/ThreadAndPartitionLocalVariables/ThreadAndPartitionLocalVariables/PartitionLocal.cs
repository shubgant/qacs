using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAndPartitionLocalVariables
{
    public class PartitionLocal
    {
        public static void Demo()
        {
            // Array to store partition-local sums
            int[] partitionSums = new int[Environment.ProcessorCount]; // One sum per partition

            // Perform parallel computation with a partition-local variable
            //The code sums all the numbers between 1 and 1000
            Parallel.For<int>(1, 1001, // Range of iterations
            () => 0, // Initialize partition-local state (localSum)
            (i, loopState, localSum) => // Body of the loop
            {
                // Compute local result (sum)
                localSum += i;
                return localSum; // Return updated partition-local state
            },
            localSum =>
            {
                // Combine local results (sums) into a global result
                //Not convinced this actually calculates the correct partition ID
                //Consecutively numbered thread pool threads probably aren't
                //running on different processors
                int partitionId = (int)Task.CurrentId % Environment.ProcessorCount; 
                partitionSums[partitionId] += localSum;
            });

            // Calculate the total sum from partition-local sums
            int totalSum = 0;
            foreach (var sum in partitionSums)
            {
                totalSum += sum;
            }

            Console.WriteLine($"Total sum: {totalSum}");
        }
    }
}
