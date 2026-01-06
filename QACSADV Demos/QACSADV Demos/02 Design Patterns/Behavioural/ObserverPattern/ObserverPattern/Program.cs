namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create subject and observers
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            // Change subject and notify observers again
            s.SubjectState = "DEF";
            s.Notify();
        }
    }
}
