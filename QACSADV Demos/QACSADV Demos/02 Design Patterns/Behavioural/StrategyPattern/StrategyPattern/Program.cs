namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating context and configuring it with ConcreteStrategyA
            Context context = new Context(new ConcreteStrategyA());
            context.ExecuteStrategy();

            // Re-configuring the context with ConcreteStrategyB
            context.SetStrategy(new ConcreteStrategyB());
            context.ExecuteStrategy();
        }
    }
}
