using System.Diagnostics;

bool IsPrime(int number)
{
    if (number < 2)
    {
        return false;
    }

    for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
    {
        if (number % divisor == 0)
        {
            return false;
        }
    }
    return true;
}

// Get primes synchronously
IList<int> GetPrimeList(IList<int> numbers)
    => numbers.Where(IsPrime).ToList();

IList<int> GetPrimeListWithParallel(IList<int> numbers)
{
    var primeNumbers = new System.Collections.Concurrent.ConcurrentBag<int>();

    Console.WriteLine($"Processors: {Environment.ProcessorCount}");
    var options = new ParallelOptions()
    {
        MaxDegreeOfParallelism = Environment.ProcessorCount
    };

    Parallel.ForEach(numbers, options, number =>
    {
        if (IsPrime(number)) primeNumbers.Add(number);
    });

    return primeNumbers.ToList();
}


var limit = 2_000_000;
var numbers = Enumerable.Range(0, limit).ToList();

var watch = Stopwatch.StartNew();
var primeNumbersFromForeach = GetPrimeList(numbers);
watch.Stop();

var watchForParallel = Stopwatch.StartNew();
var primeNumbersFromParallelForeach = GetPrimeListWithParallel(numbers);
watchForParallel.Stop();

Console.WriteLine($"Classical foreach loop | Total prime numbers : {primeNumbersFromForeach.Count} | Time Taken : {watch.ElapsedMilliseconds} ms.");
Console.WriteLine($"Parallel.ForEach loop  | Total prime numbers : {primeNumbersFromParallelForeach.Count} | Time Taken : {watchForParallel.ElapsedMilliseconds} ms.");