namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype prototype = new ConcretePrototype("Sadia Saleem", 30);
            ConcretePrototype clone = prototype.Clone() as ConcretePrototype;

            // Display original and cloned object
            prototype.DisplayInfo();
            clone.DisplayInfo();

            // Making changes to verify that deep copy is indeed deep
            clone.Name = "Isabelle Necessary";
            clone.Age = 25;

            Console.WriteLine("After changes to cloned object:");
            prototype.DisplayInfo();
            clone.DisplayInfo();
        }
    }
}
