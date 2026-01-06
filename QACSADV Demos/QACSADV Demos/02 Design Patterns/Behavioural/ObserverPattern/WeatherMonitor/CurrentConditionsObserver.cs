using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor
{
    // Concrete Observer
    public class CurrentConditionsObserver : IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public CurrentConditionsObserver(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(
                $"Current conditions: {temperature}C degrees, " +
                $"{humidity}% humidity and {pressure}hPa pressure");
        }
    }
}
