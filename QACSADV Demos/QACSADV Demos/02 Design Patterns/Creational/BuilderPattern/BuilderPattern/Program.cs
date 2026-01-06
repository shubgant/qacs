namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Manufacturer manufacturer = new Manufacturer();

            CarBuilder builder = new SaloonCarBuilder();
            manufacturer.Construct(builder);
            Car car = builder.GetCar();
            cars.Add(car);

            builder = new SUVCarBuilder();
            manufacturer.Construct(builder);
            car = builder.GetCar();
            cars.Add(car);

            builder = new EstateCarBuilder();
            manufacturer.Construct(builder);
            car = builder.GetCar();
            cars.Add(car);

            builder = new SportsCarBuilder();
            manufacturer.Construct(builder);
            car = builder.GetCar();
            cars.Add(car);

            cars.ForEach(c => c.Show());
        }
    }
}
