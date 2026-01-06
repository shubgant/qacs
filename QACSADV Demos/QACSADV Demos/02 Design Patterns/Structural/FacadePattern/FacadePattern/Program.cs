namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DvdPlayer dvd = new DvdPlayer();
            Projector projector = new Projector();
            TheatreLights lights = new TheatreLights();

            HomeTheatreFacade homeTheater = new HomeTheatreFacade(dvd, projector, lights);
            homeTheater.WatchFilm("Postman Pat in 'The Heist!'");
            homeTheater.EndFilm();
        }
    }
}
