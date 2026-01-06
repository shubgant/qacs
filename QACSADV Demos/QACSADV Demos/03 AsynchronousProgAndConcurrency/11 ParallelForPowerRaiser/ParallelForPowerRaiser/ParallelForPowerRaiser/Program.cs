using System;
using System.Threading.Tasks;

namespace ParallelForPowerRaiser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Define an array of numbers
            long[,] numbers = new long[11, 11];

            GeneratePowersUsingParallelFor(numbers);
            //GeneratePowersUsingParallelForEach(numbers);

            Console.WriteLine("Parallel processing complete.");

            PrintPowersInSequence(numbers);

            GetArrayTotalUsingParallelForAndThreadLocalVariables(numbers);
        }

        private static void GeneratePowersUsingParallelForEach(long[,] numbers)
        {
            // Perform some operation on each element of the array using ParallelForEach
            int[] seednums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(seednums, i =>
            {
                // Generate the first 10 powers of i
                for (int j = 1; j < 11; j++)
                {
                    numbers[i, j] = (long)Math.Pow(i, j);
                    Console.WriteLine($"{i,2} raised to the power of {j,2} is {numbers[i, j],12}");
                }
            });
        }

        private static void GeneratePowersUsingParallelFor(long[,] numbers)
        {
            // Perform some operation on each element of the array using ParallelFor
            Parallel.For(0, 11, i =>
            {
                // Generate the first 10 powers of i
                for (int j = 1; j < 11; j++)
                {
                    numbers[i, j] = (long)Math.Pow(i, j);
                    Console.WriteLine($"{i,2} raised to the power of {j,2} is {numbers[i, j],12}");
                }
            });
        }
        private static void PrintPowersInSequence(long[,] numbers)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i,2} raised to the power of {j,2} is {numbers[i, j],12}");
                }
            }
        }

        private static void GetArrayTotalUsingParallelForAndThreadLocalVariables(long[,] numbers)
        {
            long total = 0;
            Parallel.For<long>(0, numbers.GetLength(0), () => 0,
            (i, loop, subtotal) =>
            {
                for (int j = 0; j < numbers.GetLength(0); j++)
                    subtotal += numbers[i, j];
                return subtotal;
            },
            subtotal => Interlocked.Add(ref total, subtotal));

            Console.WriteLine("The total is {0:N0}", total);
        }
    }

}
