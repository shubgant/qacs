namespace AsyncDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsyncClass c = new AsyncClass();

            // Use an async delegate three different ways
            c.AsyncWithPolling();

            c.AsyncWithBlock();

            //c.AsyncWithCallback();
        }
    }
}
  
