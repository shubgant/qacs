namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beverage> beverages = new List<Beverage>();

            Beverage beverage;
            //Create new beverage
            beverage = new Espresso();
            beverages.Add(beverage);

            //Create new beverage
            beverage = new Espresso();
            // Decorate it with steamed milk
            beverage = new SteamedMilk(beverage);
            beverages.Add(beverage);

            //Create new beverage
            beverage = new Espresso();
            // Decorate it with ChocolateSauce
            beverage = new ChocolateSauce(beverage);
            beverages.Add(beverage);

            //The works!
            beverage = new Espresso();
            // Decorate the espresso with chocolate sauce
            beverage = new ChocolateSauce(beverage);
            // Decorate it further with steamed milk
            beverage = new SteamedMilk(beverage);
            beverages.Add(beverage);

            //print individual prices and total
            beverages.ForEach(beverage =>  Console.WriteLine($"{beverage.Description} {beverage.Cost:£0.00}"));
            Console.WriteLine($"Total Cost: {beverages.Sum(b => b.Cost):£0.00}");
        }
    }
}
