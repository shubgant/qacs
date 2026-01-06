namespace AsyncAndAwaitBreakfast
{
    internal class Program
    {
        // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
        internal class Bacon { }
        internal class Coffee { }
        internal class Egg { }
        internal class Juice { }
        internal class Toast { }

        static async Task Main(string[] args)
        {
            //SyncBreakfast sb = new SyncBreakfast();
            //sb.MakeBreakfast();

            DontBlockAwait dbab = new DontBlockAwait();
            await dbab.MakeBreakfast();
            Console.WriteLine("All Done!");
        }
    }
}
