using System.Diagnostics;
using System;

namespace AbstractFactoryPattern
{

    //The "Abstract Factory" and "Factory" patterns are both creational design patterns
    //that abstract the process of object creation in software development.However,
    //they are used in different scenarios and address different levels of complexity.
    //
    //Abstract Factory Pattern
    //The Abstract Factory pattern provides an interface for creating families of related
    //or dependent objects without specifying their concrete classes.The pattern is used
    //when you have interrelated objects that need to be created together. If one object
    //is processed, related objects need to be accordingly adapted.

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create city vehicles
            IVehicleFactory cityFactory = new CityVehicleFactory();
            ICar cityCar = cityFactory.CreateCar();
            ILorry cityLorry = cityFactory.CreateLorry();
            cityCar.Drive();
            cityLorry.LoadCargo();

            // Create out of town vehicles
            IVehicleFactory outOfTownFactory = new OutOfTownVehicleFactory();
            ICar offroadCar = outOfTownFactory.CreateCar();
            ILorry offroadLorry = outOfTownFactory.CreateLorry();
            offroadCar.Drive();
            offroadLorry.LoadCargo();
        }
    }
}
