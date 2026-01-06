namespace FactoryPattern
{
    //The "Abstract Factory" and "Factory" patterns are both creational design patterns
    //that abstract the process of object creation in software development.However,
    //they are used in different scenarios and address different levels of complexity.
    //
    //Factory Pattern (Simple Factory and Factory Method)
    //The Factory Pattern is used to create objects from a set of related classes,
    //deciding which class to instantiate based on logic, typically a condition.The
    //pattern abstracts the instantiation process and allows the client to operate
    //independently from the actual classes needed to create instances. There are two
    //variations often discussed under Factory Pattern: the Simple Factory, which isn't
    //officially a design pattern by the Gang of Four, and the Factory Method.
    //
    //Factory Method Pattern
    //The Factory Method pattern defines an interface for creating an object, but lets
    //subclasses decide which class to instantiate.It lets a class defer instantiation to
    //subclasses.
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carFactory = new CarFactory();
            Vehicle myCar = carFactory.CreateVehicle();
            myCar.Drive();

            VehicleFactory lorryFactory = new LorryFactory();
            Vehicle myLorry = lorryFactory.CreateVehicle();
            myLorry.Drive();
        }
    }
}
