using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Facade
    public class HomeTheatreFacade
    {
        private DvdPlayer _dvd;
        private Projector _projector;
        private TheatreLights _lights;

        public HomeTheatreFacade(DvdPlayer dvd, Projector projector, TheatreLights lights)
        {
            _dvd = dvd;
            _projector = projector;
            _lights = lights;
        }

        public void WatchFilm(string film)
        {
            Console.WriteLine("Get ready to watch a Film...");
            _lights.Dim(10);
            _projector.On();
            _projector.SetInputDvd(_dvd);
            _projector.WideScreenMode();
            _dvd.On();
            _dvd.Play(film);
        }

        public void EndFilm()
        {
            Console.WriteLine("Shutting down the Film theatre...");
            _dvd.Off();
            _projector.Off();
            _lights.On();
        }
    }

}
